namespace FSharpImplementations

type HtmlDownloaderFSharp() = 
    member this.DownloadHtml url =
        this.HtmlDownloaderCall url this.DownloaderCallback

    member this.HtmlDownloaderCall url callback =
        let request = System.Net.WebRequest.Create(System.Uri(url))
        use response = request.GetResponse()
        use responseStream = response.GetResponseStream()
        use reader = new System.IO.StreamReader(responseStream)
        callback reader

    member this.DownloaderCallback (reader:System.IO.StreamReader) = 
        reader.ReadToEnd()
