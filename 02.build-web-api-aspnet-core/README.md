# [ASP\.NET Core コントローラーを使用して Web API を作成する \- Training \| Microsoft Learn](https://learn.microsoft.com/ja-jp/training/modules/build-web-api-aspnet-core/)

## HttpRepl
- 参考: [HttpRepl を使用して Web API をテストする \| Microsoft Learn](https://learn.microsoft.com/ja-jp/aspnet/core/web-api/http-repl/?view=aspnetcore-6.0&tabs=windows)

任意の場所でホストされている Web API をテストするためのクロスプラットフォーム コマンド ライン ツール。
これを使うことでコマンドから Web API を呼び出して簡易な検証が可能になる。

### インストール方法
以下コマンドを実行する。

```cmd
dotnet tool install -g Microsoft.dotnet-httprepl
```

### 使い方
1. localhost に接続する
    ```cmd
    httprepl https://localhost:{PORT}
    ```
2. 使用可能なエンドポイントを調べる
    ```cmd
    ls
    ```
    以下のような結果が返ってくる
    ```cmd
    https://localhost:{PORT}/> ls
    .                 []
    WeatherForecast   [GET]
    ```
3. エンドポイントへ移動して、要求メソッドを指定すると結果が返ってくる
    ```cmd
    cd WeatherForecast
    get
    ```
    ```cmd
    HTTP/1.1 200 OK
    Content-Type: application/json; charset=utf-8
    Date: Fri, 02 Apr 2021 17:31:43 GMT
    Server: Kestrel
    Transfer-Encoding: chunked
    [
        {
        "date": 4/3/2021 10:31:44 AM,
        "temperatureC": 13,
        "temperatureF": 55,
        "summary": "Sweltering"
        },
        {
        "date": 4/4/2021 10:31:44 AM,
        "temperatureC": -13,
        "temperatureF": 9,
        "summary": "Warm"
        },
        // ..
    ]
    ```
