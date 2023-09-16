<?php 

require_once 'inc.config.php';


try
{
$Launcher = $pdo->prepare('SELECT * FROM web_launcher LIMIT 1');
$Launcher->execute();
$resultLauncher = $Launcher->fetch(PDO::FETCH_ASSOC);

// Crie um array associativo com os valores obtidos do banco de dados
$response = array(
    //'success' => true,
    'launcherversion' => $resultLauncher['launcherVer'],
    'status' => $resultLauncher['status'],
    'message' => $resultLauncher['message'],
    'webpage' => $resultLauncher['webAnnounce'],
    'webrank' => $resultLauncher['webRanking'],
    'files' => $resultLauncher['urlFiles'],
    'userlist' => $resultLauncher['userFileList'],
    'updateurl' => $resultLauncher['urlUpdate'],
    'clientversion' => $resultLauncher['clientVer'],
    'webbrowser' => $resultLauncher['webBrowser'],
    'discord_link' => $resultLauncher['urlDiscord'],
    'facebook_link' => $resultLauncher['urlFacebook'],
    'site_link' => $resultLauncher['urlSite'],  
    'code' => $resultLauncher['codeAccess'],
    'paste' => $resultLauncher['regeDit'],
    'repairurl' => $resultLauncher['urlRapair'],
    'color' => $resultLauncher['launcherColor'],
    'registeurl' => $resultLauncher['urlRegister'],
    'youtubeurl' => $resultLauncher['urlYoutube']
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