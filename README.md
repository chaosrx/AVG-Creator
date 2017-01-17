# AVG Creator
AVG Creator 是一款開放、簡單、易用的冒險故事遊戲引擎，只要學會簡易的腳本就能建立一款自己的 AVG 遊戲。
# 注意事項
這款軟體目前仍處於開發狀態，腳本、函數及功能都還有可能變更的可能性，在穩定版本發布之前，不建議作為正式遊戲開發用途。
#腳本釋例
```
//AVG Creator Sample Script
//圖片素材來自英雄聯盟
//背景音樂來自英雄聯盟
//音效來自小森 平（http://taira-komori.jpn.org/freesoundtw.html）
//
//
//腳本最前面加上雙斜槓，AVG Creator 就不會將其解讀為指令
//所有資源文件（圖片、音樂）都應存放於 assets 資料夾中
//遊戲資訊：[info]遊戲名稱,作者,備註,AVG Creator版本,遊戲版本
//載入背景：[bgim]要載入的背景圖片檔名（應放在 assets 資料夾下）
//顯示對話：[dial]角色名稱,對話內容（不可包含小寫逗號）,大頭貼圖片檔名
//載入角色：[char]1/2（最多可同時顯示兩個角色）,圖片檔名,X座標,Y座標,圖片長度,圖片寬度
//場景結束：[next]等待玩家再次點擊滑鼠，載入下一個場景（此函數沒有提供參數，直接調用即可）
//清除角色：[crcl]1/2/3（清除角色1或角色2，3為同時清除兩者）
//清除對話：[dlcl]清除對話框內容及大頭貼（此函數沒有提供參數，直接調用即可）
//背景音樂：[plmc]背景音樂檔名（支援mp3、wav格式）,音量（0~100）
//停止播放：[stmc]停止播放目前背景音樂（此函數沒有提供參數，直接調用即可）
//播放音效：[plau]音效檔名（支援mp3、wav格式）,音量（0~100） 音效播放一次即停止，故不提供函數來停止播放
//全屏模式：[full]隱藏對話框（此函數沒有提供參數，直接調用即可）
//退出全屏：[show]顯示對話框（此函數沒有提供參數，直接調用即可）
//
//
[info]League of Legends,Gentle_Shao,這款遊戲是開發釋例,1000,v1.0.0.0
[plmc]music\background.mp3,50
[bgim]background\1_forest_a.jpg
[dial]納瑟斯,什麼？！你說雷尼克頓不是我的親哥哥...,avatar\nasus.jpg
[char]1,character\nasus.png,664,172,286,330
//[char]2,character\nasus.png,264,172,186,230
[next]
[full]
[plau]music\poka01.mp3,100
[bgim]background\1_forest_b.jpg
[dial]納瑟斯,怎麼可能呢,avatar\nasus.jpg
[next]
[show]
//[dlcl]
[crcl]3
[stmc]
```