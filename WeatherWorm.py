import requests

# {
#   "coord": {
#     "lon": 10.99,
#     "lat": 44.34
#   },
#   "weather": [
#     {
#       "id": 501,
#       "main": "Rain",
#       "description": "moderate rain",
#       "icon": "10d"
#     }
#   ],
#   "base": "stations",
#   "main": {
#     "temp": 298.48,
#     "feels_like": 298.74,
#     "temp_min": 297.56,
#     "temp_max": 300.05,
#     "pressure": 1015,
#     "humidity": 64,
#     "sea_level": 1015,
#     "grnd_level": 933
#   },
#   "visibility": 10000,
#   "wind": {
#     "speed": 0.62,
#     "deg": 349,
#     "gust": 1.18
#   },
#   "rain": {
#     "1h": 3.16
#   },
#   "clouds": {
#     "all": 100
#   },
#   "dt": 1661870592,
#   "sys": {
#     "type": 2,
#     "id": 2075663,
#     "country": "IT",
#     "sunrise": 1661834187,
#     "sunset": 1661882248
#   },
#   "timezone": 7200,
#   "id": 3163858,
#   "name": "Zocca",
#   "cod": 200
# }
#
# main
#   main.temp溫度。單位默認值：開爾文，公制：攝氏度，英制：華氏度。
#   main.feels_like溫度。該溫度參數說明了人類對天氣的感知。單位默認值：開爾文，公制：攝氏度，英制：華氏度。
#   main.pressure大氣壓力（在海平面上，如果沒有 sea_level 或 grnd_level 數據），hPa
#   main.humidity濕度， ％
#   main.temp_min目前最低氣溫。這是目前觀測到的最低溫度（在大都市和城市地區）。單位默認值：開爾文，公制：攝氏度，英制：華氏度。
#   main.temp_max此刻的最高溫度。這是目前觀測到的最高溫度（在大都市和城市地區）。單位默認值：開爾文，公制：攝氏度，英制：華氏度。
#   main.sea_level海平面大氣壓，hPa
#   main.grnd_level地面大氣壓，hPa
# visibility能見度，米。能見度最大值為10km
# wind
#   wind.speed風速。單位 默認值：米/秒，公制：米/秒，英制：英里/小時。
#   wind.deg風向，度（氣象）
#   wind.gust一陣風。單位 默認值：米/秒，公制：米/秒，英制：英里/小時
# clouds
#   clouds.all雲度，%
# rain
#   rain.1h最近1小時雨量，mm
#   rain.3h最近3小時雨量，mm
# snow
#   snow.1h最近1小時積雪量，mm
#   snow.3h最近3小時積雪量，mm
# dt數據計算時間，unix，UTC
#
# K-273.15=C
#
# API金鑰：89007f448fb36323ca0884a10d982594

def weatherPrint(城市):
    API密鑰 = "請輸入你的API密鑰"
    url = f'https://api.openweathermap.org/data/2.5/weather?q={城市}&appid={API密鑰}&lang=zh_tw'
    天氣資料 = requests.get(url)
    print("請求的地點為：" + 城市)
    print("目前天氣概況：" + 天氣資料.json()["weather"][0]["description"])
    print("氣溫：" + str(round(天氣資料.json()["main"]["temp"]-273.15,2)) + "度攝氏")
    print("    目前最高溫：" + str(round(天氣資料.json()["main"]["temp_max"] - 273.15,2)) + "度攝氏")
    print("    目前最低溫：" + str(round(天氣資料.json()["main"]["temp_min"] - 273.15, 2)) + "度攝氏")
    print("    體感溫度：" + str(round(天氣資料.json()["main"]["feels_like"] - 273.15, 2)) + "度攝氏")
    print("濕度：" + str(天氣資料.json()["main"]["humidity"]) + "%")
    # print("地面大氣壓：" + str(天氣資料.json()["main"]["grnd_level"]) + "hpa")
    # print("海平面大氣壓：" + str(天氣資料.json()["main"]["sea_level"]) + "hpa")
    # wind
    #   wind.speed風速。單位 默認值：米/秒，公制：米/秒，英制：英里/小時。
    #   wind.deg風向，度（氣象）
    #   wind.gust一陣風。單位 默認值：米/秒，公制：米/秒，英制：英里/小時
    print("  ")
    print("風速：" + str(天氣資料.json()["wind"]["speed"]) + "m/s")
    print("風向：" + str(天氣資料.json()["wind"]["deg"]) + "度")
    # clouds
    #   clouds.all雲度，%
    print("  ")
    print("雲度：" + str(天氣資料.json()["clouds"]["all"]) + "%")
    # snow
    #   snow.1h最近1小時積雪量，mm
    #   snow.3h最近3小時積雪量，mm
    # print("  ")
    # print("最近1小時積雪量：" + str(天氣資料.json()["snow"]["1h"]) + "%")
    # print("最近3小時積雪量：" + str(天氣資料.json()["snow"]["3h"]) + "%")

def weatherWriteTxt(城市,檔案 = "weatherOutput.txt"):
    f = open(檔案,"w+")
    API密鑰 = "89007f448fb36323ca0884a10d982594"
    url = f'https://api.openweathermap.org/data/2.5/weather?q={城市}&appid={API密鑰}&lang=zh_tw'
    天氣資料 = requests.get(url)
    # try:
    print("請求的地點為：" + 城市,file=f) # + "目前天氣概況為：" + 天氣資料.json()["weather"]["main"])
    print("目前天氣概況：" + 天氣資料.json()["weather"][0]["description"],file=f)
    print("氣溫：" + str(round(天氣資料.json()["main"]["temp"]-273.15,2)) + "度攝氏",file=f)
    print("    目前最高溫：" + str(round(天氣資料.json()["main"]["temp_max"] - 273.15,2)) + "度攝氏",file=f)
    print("    目前最低溫：" + str(round(天氣資料.json()["main"]["temp_min"] - 273.15, 2)) + "度攝氏",file=f)
    print("    體感溫度：" + str(round(天氣資料.json()["main"]["feels_like"] - 273.15, 2)) + "度攝氏",file=f)
    print("濕度：" + str(天氣資料.json()["main"]["humidity"]) + "%",file=f)
    # print("地面大氣壓：" + str(天氣資料.json()["main"]["grnd_level"]) + "hpa",file=f)
    # print("海平面大氣壓：" + str(天氣資料.json()["main"]["sea_level"]) + "hpa",file=f)
    # wind
    #   wind.speed風速。單位 默認值：米/秒，公制：米/秒，英制：英里/小時。
    #   wind.deg風向，度（氣象）
    #   wind.gust一陣風。單位 默認值：米/秒，公制：米/秒，英制：英里/小時
    print("  ")
    print("風速：" + str(天氣資料.json()["wind"]["speed"]) + "m/s",file=f)
    print("風向：" + str(天氣資料.json()["wind"]["deg"]) + "度",file=f)
    # clouds
    #   clouds.all雲度，%
    print("  ")
    print("雲度：" + str(天氣資料.json()["clouds"]["all"]) + "%",file=f)
    # snow
    #   snow.1h最近1小時積雪量，mm
    #   snow.3h最近3小時積雪量，mm
    # print("  ")
    # print("最近1小時積雪量：" + str(天氣資料.json()["snow"]["1h"]) + "%",file=f)
    # print("最近3小時積雪量：" + str(天氣資料.json()["snow"]["3h"]) + "%",file=f)
    #
    # except:
    #     pass
    #     continue
    print("寫入成功！")
    print("此檔案為文字字串格式，請直接開啟即可讀取。")

def weatherWriteFormat(城市,檔案 = "weatherOutput.pgbWeather"):
    f = open(檔案,"w+")
    API密鑰 = "89007f448fb36323ca0884a10d982594"
    url = f'https://api.openweathermap.org/data/2.5/weather?q={城市}&appid={API密鑰}&lang=zh_tw'
    天氣資料 = requests.get(url)
    # try:
    print(城市,file=f) # + "目前天氣概況為：" + 天氣資料.json()["weather"]["main"])
    print(天氣資料.json()["weather"][0]["description"],file=f)
    print(str(round(天氣資料.json()["main"]["temp"]-273.15,2)),file=f)
    print(str(round(天氣資料.json()["main"]["temp_max"] - 273.15,2)),file=f)
    print(str(round(天氣資料.json()["main"]["temp_min"] - 273.15, 2)),file=f)
    print(str(round(天氣資料.json()["main"]["feels_like"] - 273.15, 2)),file=f)
    print(str(天氣資料.json()["main"]["humidity"]),file=f)
    # print("地面大氣壓：" + str(天氣資料.json()["main"]["grnd_level"]) + "hpa",file=f)
    # print("海平面大氣壓：" + str(天氣資料.json()["main"]["sea_level"]) + "hpa",file=f)
    # wind
    #   wind.speed風速。單位 默認值：米/秒，公制：米/秒，英制：英里/小時。
    #   wind.deg風向，度（氣象）
    #   wind.gust一陣風。單位 默認值：米/秒，公制：米/秒，英制：英里/小時
    print(str(天氣資料.json()["wind"]["speed"]),file=f)
    print(str(天氣資料.json()["wind"]["deg"]),file=f)
    # clouds
    #   clouds.all雲度，%
    print(str(天氣資料.json()["clouds"]["all"]),file=f)
    # snow
    #   snow.1h最近1小時積雪量，mm
    #   snow.3h最近3小時積雪量，mm
    # print("  ")
    # print("最近1小時積雪量：" + str(天氣資料.json()["snow"]["1h"]) + "%",file=f)
    # print("最近3小時積雪量：" + str(天氣資料.json()["snow"]["3h"]) + "%",file=f)
    #
    # except:
    #     pass
    #     continue
    print("寫入成功！")
    print("此檔案為企鵝哥格式，無法正常開啟，請使用VB讀取器開啟")
