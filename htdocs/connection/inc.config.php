<?php 
// Conexão com o banco de dados
session_start();
date_default_timezone_set('America/Sao_Paulo');
set_time_limit(0);
try{
	
define( 'DB_TYPE', 'pgsql' );
define( 'DB_HOST', 'localhost' );
define( 'DB_PORT', 5501 );
define( 'DB_USER', 'postgres' );
define( 'DB_PASS', '726B9F4A15A087531308B50ED3B1EDCD' );
define( 'DB_NAME', 'postgres' );

$pdo = new PDO(''.DB_TYPE.':dbname='.DB_NAME.';host='.DB_HOST.';port='.DB_PORT.'', DB_USER, DB_PASS);

$sett = $pdo->prepare('SELECT "codeAccess" FROM web_launcher LIMIT 1');
$sett->execute();
$settRow = $sett->fetch(PDO::FETCH_ASSOC);
}
catch( Exception $e)
{
echo 'error'.$e;
}

define( '_CODE', $settRow['codeAccess'] );


$current_date =  date("Ymd"); // Data atual 


function pregLogin($n) {

    if (is_null($n)) {
        $n = '';
    }
    $n = preg_replace('/[^[:alnum:]]/', '', $n);
    $n = trim($n);
    $n = htmlspecialchars($n, ENT_QUOTES, 'UTF-8');
    return mb_strtolower($n);
  }
  function _uname($n) {

    if (is_null($n)) {
        $n = '';
    }
    $n = preg_replace('/[^[:alnum:] -]/', '', $n);
    $n = trim($n);
    $n = htmlspecialchars($n, ENT_QUOTES, 'UTF-8');
    return ($n);
  }

function encripitar($senha){
  $salt = '/x!a@r-$r%an¨.&e&+f*f(f(a)';
  $output = hash_hmac('md5', $senha, $salt);
  return $output;
}

function ping( $ip, $port ) {
    return @fsockopen( $ip, $port, $errno, $errstr, 1 ) ? true : false;
}

  function name_patents( $type ) {
    switch ( $type ) {
			case 0: 
				return "Novato";
				
			case 1:
				return "Recruta";
				
			case 2:
				return "Soldado";
				
			case 3:
				return "Cabo";
				
			case 4:
				return "Sargento";
				
			case 5:
				return "Terceiro Sargento 1";
				
			case 6:
				return "Terceiro Sargento 2";
				
			case 7:
				return "Terceiro Sargento 3";
				
			case 8:
				return "Segundo Sargento 1";
				
			case 9:
				return "Segundo Sargento 2";
				
			case 10:
				return "Segundo Sargento 3";
				
			case 11:
				return "Segundo Sargento 4";
				
			case 12:
				return "Primeiro Sargento 1";
				
			case 13:
				return "Primeiro Sargento 2";
				
			case 14:
				return "Primeiro Sargento 3";
				
			case 15:
				return "Primeiro Sargento 4";
				
			case 16:
				return "Primeiro Sargento 5";
				
			case 17:
				return "Segundo Tenente 1";
				
			case 18:
				return "Segundo Tenente 2";
				
			case 19:
				return "Segundo Tenente 3";
				
			case 20:
				return "Segundo Tenente 4";
				
			case 21:
				return "Primeiro Tenente 1";
				
			case 22:
				return "Primeiro Tenente 2";
				
			case 23:
				return "Primeiro Tenente 3";
				
			case 24:
				return "Primeiro Tenente 4";
				
			case 25:
				return "Primeiro Tenente 5";
				
			case 26:
				return "Capitão 1";
				
			case 27:
				return "Capitão 2";
				
			case 28:
				return "Capitão 3";
				
			case 29:
				return "Capitão 4";
				
			case 30:
				return "Capitão 5";
				
			case 31:
				return "Major 1";
				
			case 32:
				return "Major 2";
				
			case 33:
				return "Major 3";
				
			case 34:
				return "Major 4";
				
			case 35:
				return "Major 5";
				
			case 36:
				return "Tenente Coronel 1";
				
			case 37:
				return "Tenente Coronel 2";
				
			case 38:
				return "Tenente Coronel 3";
				
			case 39:
				return "Tenente Coronel 4";
				
			case 40:
				return "Tenente Coronel 5";
				
			case 41:
				return "Coronel 1";
				
			case 42:
				return "Coronel 2";
				
			case 43:
				return "Coronel 3";
				
			case 44:
				return "Coronel 4";
				
			case 45:
				return "Coronel 5";
				
			case 46:
				return "General de Brigada";
				
			case 47:
				return "General de Divisão";
				
			case 48:
				return "General de Exército";
				
			case 49:
				return "Marechal";
				
			case 50:
				return "Herói de Guerra";
				
			case 51:
				return "Hero";
				
			case 53:
				return "Game Master";
				
			case 54:
				return "Moderador";

			default: 
				return "Error";	
		}
	}

	function name_vip($p)
	{
		switch ($p)
				{
		case 0:
		return "Free";
		case 1:
		return "Basic";
		case 2:
		return "Plus";
		case 3:
		return "Master";
		case 4:
		return "Combat";
		case 5:
		return "Booster";
		default:
		return "Error";
		}
	}

if(!isset($_SERVER['HTTP_X_LAUNCHER_HEADER'])) {
    //header('HTTP/1.0 403 Forbidden');
	//header("Location: https://www.facebook.com/combatglobal/");
    //die('Acesso proibido');
}elseif($_SERVER['HTTP_X_LAUNCHER_HEADER'] != _CODE)
{
	//header('HTTP/1.0 403 Forbidden');
	//header("Location: https://www.facebook.com/combatglobal/");
   // die('Acesso proibido');
}
?>