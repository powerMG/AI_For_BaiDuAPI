using AI_ImgDiscern.Models.Baidu.Aip.BodyAnalysis;
using Baidu.Aip.BodyAnalysis;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AI_ImgDiscern.Controllers
{
    public class imgServer
    {
        public static JObject BodyNumDemp()
        {
            var client = new Body(BodyModel.API_KEY, BodyModel.SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间}\
            var image = File.ReadAllBytes(Path.GetFullPath(string.Format("{0}/Content/image/timg.jpg", HttpRuntime.AppDomainAppPath.ToString())));
            // 调用人流量统计，可能会抛出网络等异常，请使用try/catch捕获
            var options = new Dictionary<string, object>{
        {"show", "true"}
    };
            var result = client.BodyNum(image, options);

            //        //Console.WriteLine(result);
            //        // 如果有可选参数
            //        var options = new Dictionary<string, object>{
            //    {"area", "0,0,100,100,200,200"},
            //    {"show", "false"}
            //};
            //        // 带参数调用人流量统计
            //        result = client.BodyNum(image, options);
            return result;
        }
    }
}