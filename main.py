# import random
# import string
import WeatherWorm
import sys

# 數字 = string.digits
# 英文 = string.ascii_letters
# 字母表 = list(數字 + 英文)
#
# random.shuffle(字母表)
#
# 長度 = int(input("輸入密碼位數:"))
# 密碼 = "".join(字母表[:長度])
# print(f"你的密碼是：{密碼}")

print("(A) 讀取OpenWeatherAPI並顯示於此 \n(B) 讀取OpenWeatherAPI並作為已格式化之文字輸出至指定位置 \n(C) 讀取OpenWeatherAPI並以pgbWeather格式輸出至指定位置")
操作 = input("請選擇操作：").upper()
if sys.argv[0] == "/A":
    WeatherWorm.weatherPrint(城市 = sys.argv[1])
elif sys.argv[0] == "/B":
    路徑 = sys.argv[2]
    WeatherWorm.weatherWriteTxt(城市 = sys.argv[1], 檔案 = 路徑)
elif sys.argv[0] == "/C":
    路徑 = sys.argv[2]
    WeatherWorm.weatherWriteFormat(城市 = sys.argv[1],檔案 = 路徑)
else:
    print("錯誤！你給定的參數不正確！")
#
# if 操作 == "A":
#     WeatherWorm.weatherPrint(城市 = input('你要查詢的城市名稱，英文的:'))
# elif 操作 == "B":
#     路徑 = input("請給予指定路徑，不給定則輸出至此軟體之路徑:") + "Output.txt"
#     WeatherWorm.weatherWriteTxt(城市 = input('你要寫入TXT檔的城市名稱，英文的:'), 檔案 = 路徑)
# elif 操作 == "C":
#     路徑 = input("請給予指定路徑，不給定則輸出至此軟體之路徑:") + "Output.pgbWeather"
#     WeatherWorm.weatherWriteFormat(城市 = input('你要寫入TXT檔的城市名稱，英文的:'),檔案 = 路徑)
# else:
#     print("錯誤！你給定的參數不正確！")