[Console]::OutputEncoding = [System.Text.Encoding]::GetEncoding('cp866')

$check_static_ip = netsh interface ip show address name="Ethernet" | out-String
$check_static_ip = $check_static_ip.Contains('Да')

if ($check_static_ip -eq 'True') {
    Write-Output "IP динамический"
}
else {
    Write-Output "IP статический"
}
