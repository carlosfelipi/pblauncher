<?php 

require_once 'inc.config.php';


try
{

 $Status = ping( "connect.pbcombat.com.br", 381910 ) ? 'Online' : 'Offline';
 $Players = $pdo->query("SELECT COUNT(*) FROM players WHERE online='t'")->fetchColumn();
 
 $Bonus = $pdo->prepare('SELECT * FROM server_events_rankup LIMIT 1');
 $Bonus->execute();
 $resultBonus = $Bonus->fetch(PDO::FETCH_ASSOC);

// Crie um array associativo com os valores obtidos do banco de dados
$response = array(
   
    'ServerStatus' => $Status,
    'ServerPlayer' => $Players,
    'ServerBonus' => '+Exp:'.$resultBonus['percent_xp'].' +Gp:'.$resultBonus['percent_gp']
);

// Defina o cabeçalho Content-Type como application/json
header('Content-Type: application/json');

// Imprima a resposta da API como um objeto JSON
echo json_encode($response);



}catch(PDOException) 
{
	die ();	
}	


?>