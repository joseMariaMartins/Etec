<?php
$salario = $_GET['salario'];
$desconto = $_GET['desconto'];

$salario_apos_inss = $salario - $desconto;

if ($salario_apos_inss <= 3000) {
    $imposto_renda = $salario_apos_inss * 0.15;
} else {
    $imposto_renda = $salario_apos_inss * 0.27;
}

$salario_liquido = $salario_apos_inss - $imposto_renda;

echo "Seu salário líquido é: " . $salario_liquido;
?>