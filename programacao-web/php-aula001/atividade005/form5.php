<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Calculador INSS</title>
</head>
<body>
    <form action="resultado5.php" method="GET">
        <label for="salario">Salário Bruto:</label>
        <input type="number" name="salario" id="salario" required>
        <br>
        <label for="desconto">Desconto do INSS:</label>
        <input type="number" name="desconto" id="desconto" required>
        <br>
        <button type="submit">Calcular</button>
    </form>
</body>
</html>