<?php
$n1 = $_GET['n1'];

if ($n1 <= 12) {
    echo "Sua compra deu: R$ " . number_format($n1 * 1.3, 2, ',', '.');
} else {
    echo "Sua compra deu: R$ " . number_format($n1 * 1, 2, ',', '.');
}
?>