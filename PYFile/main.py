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

# 操作 = input("請選擇操作：").upper()
try:
    print("  =====  ==       ==       =========\n =     = ==  ===  ==       ==\n =     =  == === ==        =========\n  =====    === ===  eather ==       inder")
    if sys.argv[1].upper() == "/A":
        WeatherWorm.weatherPrint(城市 = sys.argv[2])
    elif sys.argv[1].upper() == "/B":
        路徑 = sys.argv[3]
        WeatherWorm.weatherWriteTxt(城市 = sys.argv[2], 檔案 = 路徑)
    elif sys.argv[1].upper() == "/C":
        路徑 = sys.argv[3]
        WeatherWorm.weatherWriteFormat(城市 = sys.argv[2],檔案 = 路徑)
    elif sys.argv[1].upper() == "/H":
        print("/A 讀取天氣狀況並顯示\n 給定參數：\n    City：欲查詢的城市\n/B 讀取OpenWeatherAPI並作為已格式化之文字輸出至指定位置\n 給定參數：\n    City：欲查詢的城市\n    File：儲存至指定位置(僅輸入路徑而不輸入檔名)\n/C 讀取OpenWeatherAPI並以pgbWeather格式輸出至指定位置\n 給定參數：\n    City：欲查詢的城市\n    File：儲存至指定位置(僅輸入路徑而不輸入檔名)\n/H 開啟協助頁面")
    else:
        print(sys.argv[1].upper())
        print("程式檔案名稱 [/A,/B,/C] [City] [File]")
        print("/A 讀取天氣狀況並顯示\n 給定參數：\n    City：欲查詢的城市\n/B 讀取OpenWeatherAPI並作為已格式化之文字輸出至指定位置\n 給定參數：\n    City：欲查詢的城市\n    File：儲存至指定位置(僅輸入路徑而不輸入檔名)\n/C 讀取OpenWeatherAPI並以pgbWeather格式輸出至指定位置\n 給定參數：\n    City：欲查詢的城市\n    File：儲存至指定位置(僅輸入路徑而不輸入檔名)\n/H 開啟協助頁面")

except:
    print("錯誤！\n給定的參數有誤！請確認參數是否正確，\n如果正確，請檢察主程式檔案狀態與網路連線或重新安裝，或參數給定'/h'以檢視可用參數列表\n如果仍然錯誤，請稍後再試")
    print("  ")
    print("程式檔案名稱 [/A,/B,/C] [City] [File]")
    print("/A 讀取天氣狀況並顯示\n 給定參數：\n    City：欲查詢的城市\n/B 讀取OpenWeatherAPI並作為已格式化之文字輸出至指定位置\n 給定參數：\n    City：欲查詢的城市\n    File：儲存至指定位置(僅輸入路徑而不輸入檔名)\n/C 讀取OpenWeatherAPI並以pgbWeather格式輸出至指定位置\n 給定參數：\n    City：欲查詢的城市\n    File：儲存至指定位置(僅輸入路徑而不輸入檔名)\n/H 開啟協助頁面")
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