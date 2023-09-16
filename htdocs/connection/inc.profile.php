<?php 
require_once 'inc.config.php';

try{	

$token =  filter_input(INPUT_POST, '_token' , FILTER_UNSAFE_RAW);

if($token == null){
   die();
}else{
   

$_PROFILE = $pdo->prepare('SELECT players.player_id, players.player_name, clans.clan_name, players.rank, players.exp, players.pc_cafe, players.gp, players.money,players.access_level, player_vip_expire."End"
                        FROM players
                        LEFT JOIN clans ON players.clan_id = clans.clan_id
                        LEFT JOIN player_vip_expire ON players.player_id = player_vip_expire."accountID"
                        WHERE players.token = :_token
                        LIMIT 1');

$_PROFILE->bindValue(':_token', pregLogin($token));
$_PROFILE->execute();

$result = $_PROFILE->fetch(PDO::FETCH_ASSOC);
if ($result && $result['access_level'] >= 0 && $result['access_level'] <= 6) 
{

    if($result['End'] != null)
    {
    $EndDate = $result['End'];
    $CurretDate = date("Y-m-d H:i:s");
    $End = new DateTime($EndDate);
    $Current = new DateTime($CurretDate);
    $intervalo = $End->diff($Current);
    $dias = $intervalo->days.'D';
    }else{ $dias = 'Perm.';}



// Crie um array associativo com os valores obtidos do banco de dados
$response = array(
    'Player_id' => $result['player_id'],
    'Player_name' => $result['player_name'],
    'Player_account' => $result['access_level'],
    'Clan_name' => $result['clan_name'] !== null ? $result['clan_name'] : 'no clan',
    'Player_rank' => $result['rank'],
    'Player_rankName' => name_patents($result['rank']),
    'Player_exp' => number_format($result['exp']),
    'Player_pccafe' => ($result['pc_cafe'] !== 0 ? name_vip($result['pc_cafe']).' - '.$dias : 'Free'),
    'Player_gold' => number_format($result['gp']),
    'Player_cash' => number_format($result['money'])
);



header('Content-Type: application/json');
echo json_encode($response);

die();	

}else{

 die();	
}

}
}
catch(PDOException)
{
	die();	
}
?>