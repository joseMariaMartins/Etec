<?php
    //Declaração de variáveis
    $nome = 'Fulano';
    $inteiro = 3;
    $real = 3.5;
    $logico = false;
    //Estrutura Condicional Se
    if($inteiro>=3){
        echo '<h1 style="color:silver">';
        echo 'Aprovado';
        echo '</h1>';
    }else{
        echo 'Reprovado';
    }
    //Estrutura condicional Switch
    /*$letra='z';
    switch($letra){
        case 'a':
            echo 'Vogal a';
            break;
        case 'e':
            echo 'Vogal e';
            break;
        case 'i':
            echo 'Vogal i';
            break;
        case 'o':
            echo 'Vogal o';
            break;
        case 'u':
            echo 'Vogal u';
            break;
        default:
            echo 'Consoante ou outro caracter';
            break;
    }
            */
    //Estrutura de repetição for
    /*
    $numero = 2;
    echo '<table width=80% border=1><tr><th>Número</th><th>X</th><th>Fator</th><th>=</th><th>Resultado</th></tr>';
    for($i=1;$i<=10;$i++){
        
        echo '<tr><td>'.$numero.'</td><td>X</td><td>'.$i.'</td><td>=</td><td>'.$numero*$i.'</td></tr>';
    }
        */
    //Estrutura de repetição while
    /*$numero = 2;
    $controle = 1;
    echo '<h1>Tabuada com while</h1><table width=80% border=1><tr><th>Número</th><th>X</th><th>Fator</th><th>=</th><th>Resultado</th></tr>';
    while($controle<=10){
        echo '<tr><td>'.$numero.'</td><td>X</td><td>'.$controle.'</td><td>=</td><td>'.$numero*$controle.'</td></tr>';
        $controle++;
    }*/
    //Estrutura de repetição do while
    $controle = 1;
    $numero=2;
    echo '<h1>Tabuada com  do while</h1><table width=80% border=1><tr><th>Número</th><th>X</th><th>Fator</th><th>=</th><th>Resultado</th></tr>';
    do{
        echo '<tr><td>'.$numero.'</td><td>X</td><td>'.$controle.'</td><td>=</td><td>'.$numero*$controle.'</td></tr>';
        $controle++;

    }while($controle<=10)

?>