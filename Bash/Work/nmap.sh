#!/bin/bash

# Записываем количество хостов
step=$(wc -l hosts | sed 's/ hosts//g')

# Мониторим открытые порты каждого из хостов и записываем в файл
for((i=1;i<$step+1;i++))
do
    ip=$(cat hosts | sed -n "$i"p)
    echo "Start scanning ports - "$ip
    result=$(nmap -sS -p 0-65535 -T5 -O -vvv -n -PS80,22 --reason $ip | sort | grep Discovered | sed 's/Discovered open port //g' | sed 's/\/tcp on '$ip'//g')
    echo "Print result in file ./ports/"$ip
    touch ./ports/$ip
    echo $result > ./ports/$ip
done
