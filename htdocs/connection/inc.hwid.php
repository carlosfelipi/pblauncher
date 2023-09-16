<?php 

require_once 'inc.config.php';

try{


$HWID_IN = _uname(filter_input(INPUT_POST, '_hwid', FILTER_UNSAFE_RAW));

$check_hwid = $pdo->prepare('SELECT * FROM web_launcher_hwid WHERE hwid = :h LIMIT 1');
$check_hwid->bindValue(':h', _uname($HWID_IN));
$check_hwid->execute();


$response = array();

if ($check_hwid->rowCount() == 1) {
	$result_hwid = $check_hwid->fetch(PDO::FETCH_ASSOC);

	if($result_hwid['status'] == false)
	{
		$response['Message'] = 'banned';
	}
	else
	{
		$response['Message'] = 'released';
	}
} else {

	$insert_hwid = $pdo->prepare('INSERT INTO web_launcher_hwid (hwid) VALUES (:h)');
    $insert_hwid->bindValue(':h', _uname($HWID_IN));
    $insert_hwid->execute();

    $response['Message'] = 'adding';
}

header('Content-Type: application/json');
echo json_encode($response);

	

}catch(PDOException) 
{
	die ();		
}




?>