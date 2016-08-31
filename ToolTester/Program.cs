using System;
using System.Collections.Generic;
using System.Text;
using ToolBox.Algrithm;
using ToolBox.HttpTools;
using ToolBox.ImageTools;
using ToolBox.ImageTools.Interfaces;
using ToolBox.LocalPCTools;
using ToolBox.LocalPCTools.Implemention;

namespace ToolTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var inv = new IntConventor();
            Console.Write(inv.ConvertToChineseCap("0"));
            var inver = new InverseString();
            Console.Write(inver.ReversString("Hello world"));
            //if (inver.IsPowerOfThree(0))
            //{
            //    Console.Write("Y");
            //}
            //else
            //{
            //    Console.Write("N");
            //}
            var nums = new[] { 1, 1, 2 };
            Console.Write(inver.RemoveDuplicates(nums));
            //Console.Write(inver.NumOfOne(15));
      //      var op = new TxtTestOperator();
      //      var sbPath = new StringBuilder();
      //      sbPath.AppendFormat("{0}\\{1}", op.FolderPath, "UrlPram.txt");
      //      var list = op.Read(sbPath.ToString());
      //      var strUrl = "";
      //      //var api = "Banking_ApprovalBankTransfer_Get_Report";
      //      //var api = "Player_Inactive30Months_Get_Report";
      //      //var api = "BANKING_RAKES_PLAYERS_Report";
      //      //var api = "Sportbook_Bets_Report_Report";
      //      var api = "Player_SportbookBets_Get_Report";
      //      strUrl = strUrl + api + list.ToUrlParams();

      //      /*
      //       * [NetworkCode]
      //,[NetworkId]
      //,[ReportName]
      //,[Orientation]
      //,[Main]
      //,[Header]
      //,[Footer]
      //,[Detail]
      //,[FileName]
      //,[Status]
      //,[IsDeleted]
      //,[IsActive]
      //,[IsVisible]
      //,[UpdatedDate]
      //,[UpdatedBy]
      //,[CreatedDate]
      //,[CreatedBy]
      //       */
      //      var dbModel = new PiiTemplateDbModel("[PCM_DATA].[SCHEMA_CRMDATA].[PBU_TemplateFiles_Network]");
      //      //dbModel.SetFileds("NetworkCode", "PKL");
      //      //dbModel.SetFileds("NetworkId", "112");
      //      //dbModel.SetFileds("NetworkCode", "SIM");
      //      //dbModel.SetFileds("NetworkId", "899");
      //      dbModel.SetFileds("NetworkCode", "PCG");
      //      dbModel.SetFileds("NetworkId", "114");
      //      //dbModel.SetFileds("ReportName", "BANKING_RAKES_PLAYERS_Report");
      //      dbModel.SetFileds("ReportName", "REPORT_INACTIVEPLAYERS_Report");
      //      dbModel.SetFileds("Orientation", "L");
      //      dbModel.SetFileds("Main", "SRPM_MainPCM");
      //      dbModel.SetFileds("Header", "SRPH_Logo_Rectangle_Left");
      //      dbModel.SetFileds("Footer", "SRPF_Logo_Left");
      //      //dbModel.SetFileds("Detail", "SRPD_BankingRakesPlayers");
      //      dbModel.SetFileds("Detail", "SRPD_ReportInactivePlayersReport");
      //      //dbModel.SetFileds("FileName", "BANKING_RAKES_PLAYERS");
      //      dbModel.SetFileds("FileName", "REPORT_INACTIVEPLAYERS_Report");
      //      dbModel.SetFileds("Status", "0");
      //      dbModel.SetFileds("IsDeleted", "0");
      //      dbModel.SetFileds("IsActive", "1");
      //      dbModel.SetFileds("IsVisible", "1");
      //      dbModel.SetFileds("UpdatedDate", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
      //      dbModel.SetFileds("UpdatedBy","0");
      //      dbModel.SetFileds("CreatedDate", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
      //      dbModel.SetFileds("CreatedBy", "0");

      //      var content = new List<string>();
      //      content.Add(api + "\t" + strUrl);
      //      //content.Add(dbModel.GetInserSql());
      //      //op.Write(content,"NewUrl3.txt");
      //      op.Append(content,"NewUrl3.txt");
      //      //op.Append(content, "NewUrl2.txt");

            

      //      ////#region Image operator
      //      ////var img = new ImageOperator();
      //      ////var orgPath = @"C:\Users\Seven\Desktop\matalib_install.png";
      //      ////var newImage =img.GetResizedImage(orgPath,77,77);
      //      ////newImage.Save(@"C:\Users\Seven\Desktop\newMatalib_install.png");
      //      ////#endregion

      //      //var netTxtOp = new UrlTxtOperator();
      //      //var module = new TxtIpNetConfig(netTxtOp,"NetInfo.txt");
      //      //var networkInfo = new NetshCommandInfo(module);

      //      //IpAddrOperator.OpCommand(networkInfo);
      //      //Console.Write("OK");
      //      //Console.Read();

      //      //var op = new TxtSimpleOperator();
      //      //var list = op.Read("textFiled.txt");
      //      //op.Append(list, op.FolderPath + "\\New Text Document.txt");

      //      //var op = new PNGDeal();
      //      //var list = op.GetPngs();
      //      //op.Write(list,op.FolderPath+"\\Pngs.txt");

            //var imgOper = new ImageOperator();
            //imgOper.GenerateImage(@"D:\.Net Test\1.png", @"D:\.Net Test\1-thumb.png", 210, 132);
            //Console.Read();
//            var v = Foo(32);
//            Console.WriteLine(v);
//            var a = popUp();
//            var b = TT(99);
//            var p = new PsdOperator();
//            p.Execute(@"D:\PII Proj\WIP Folder\Test\Account Details_.psd");

//            var algrithm = new MathAlgrithm();
////            var a = new int[] {-6, 6, -5, -1, -3};
////            Console.Write(algrithm.MaxSubSum(a));
//            var tree = new BinaryTree();
//            algrithm.RootFirstProcess(tree.GetRoot());
            Console.ReadKey();
        }

        static int Foo(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Foo(n - 2) + Foo(n - 1);
        }

        static int TT(int n)
        {
            if (n % 2 == 0)
            {
                return -1 * n / 2;
            }
            return n - (n - 1) / 2;
        }

        static int[] popUp()
        {
            int[] array = { 10, 14, 23, 33, 22 };

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        var tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;

        }
    }

}
