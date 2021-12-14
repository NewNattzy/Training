$Telegraf = Get-Service | Out-String

if ($Telegraf -match "Telegraf") {
    $Telegraf = Get-Service | Where-Object {$_.Status -EQ "Running"} | Out-String
    
        if ($Telegraf -notmatch "Telegraf") {
            Write-Output "Telegraf not running, trying run..."
            Start-Service Telegraf
        
            $Telegraf = Get-Service | Where-Object {$_.Status -EQ "Running"} | Out-String
        
            if ($Telegraf -notmatch "Telegraf") {
                Write-Output "Success! Telegraf running."
            }
        else {
            Write-Output "Failure! Something went wrong..."
        }
    }
    else {
        Write-Output "Telegraf running!"
    }
}
else {
    Write-Output "Telegraf not found!"
}
