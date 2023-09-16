<?php
require_once 'inc.config.php';



try{	
$response = array();	
$login =  filter_input(INPUT_POST, '_username' , FILTER_UNSAFE_RAW);
$senha =  filter_input(INPUT_POST, '_password' , FILTER_UNSAFE_RAW);
$hwid =  filter_input(INPUT_POST, '_hwid' , FILTER_UNSAFE_RAW);

if($login == null){   
	$response['Status'] = false;
}elseif($senha == null){
	$response['Status'] = false;
}elseif(strlen($login) < 4){    
	$response['Status'] = false;
}elseif(strlen($login) > 10){
	$response['Status'] = false;
}elseif(strlen($senha) < 6){
	$response['Status'] = false;
}elseif(strlen($senha) > 16){
	$response['Status'] = false;
}elseif($hwid == null){
	$response['Status'] = false;
}else{



$check_login = $pdo->prepare('SELECT * FROM players WHERE login = :username AND password = :password LIMIT 1');
$check_login->bindValue(':username', pregLogin($login));
$check_login->bindValue(':password', encripitar($senha));
$check_login->execute();

$result = $check_login->fetch(PDO::FETCH_ASSOC);

if($result  && $check_login->rowCount() == 1 && $result['access_level'] >= 0 && $result['access_level'] <= 6)
{
	$token = bin2hex(random_bytes(15));
	$updater_login = $pdo->prepare("UPDATE players SET token = :token, hwid = :hwid WHERE player_id = :id");
	$updater_login->bindValue(':id', $result['player_id']);
	$updater_login->bindValue(':token', $token);
	$updater_login->bindValue(':hwid', _uname($hwid));
	$updater_login->execute();

    $response['Status'] = true;
    $response['Player_token'] = $token;

}else{
	$response['Status'] = false; 
}

}

header('Content-Type: application/json');
echo json_encode($response);

}
catch(PDOException)
{
	die();
}

?>
