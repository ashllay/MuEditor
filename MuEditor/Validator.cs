using System;
using System.Text.RegularExpressions;

namespace MuEditor
{
	// Token: 0x0200001B RID: 27
	public class Validator
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00003424 File Offset: 0x00001624
		public static bool MyRegex(string str, string pattern)
		{
			return Regex.IsMatch(str, pattern);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000342D File Offset: 0x0000162D
		public static bool Empty(string str)
		{
			return Regex.Replace(str, "^\\s+|\\s+$", "") == "";
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00003449 File Offset: 0x00001649
		public static bool NotEmpty(string str)
		{
			return Regex.Replace(str, "^\\s+|\\s+$", "") != "";
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003465 File Offset: 0x00001665
		public static bool Email(string strEmail)
		{
			return Regex.IsMatch(strEmail, "^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$");
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003472 File Offset: 0x00001672
		public static bool URL(string strUrl)
		{
			return Regex.IsMatch(strUrl, "^(http|https)\\://([a-zA-Z0-9\\.\\-]+(\\:[a-zA-Z0-9\\.&%\\$\\-]+)*@)*((25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9])\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[1-9]|0)\\.(25[0-5]|2[0-4][0-9]|[0-1]{1}[0-9]{2}|[1-9]{1}[0-9]{1}|[0-9])|localhost|([a-zA-Z0-9\\-]+\\.)*[a-zA-Z0-9\\-]+\\.(com|edu|gov|int|mil|net|org|biz|arpa|info|name|pro|aero|coop|museum|[a-zA-Z]{1,10}))(\\:[0-9]+)*(/($|[a-zA-Z0-9\\.\\,\\?\\'\\\\\\+&%\\$#\\=~_\\-]+))*$");
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000347F File Offset: 0x0000167F
		public static bool IP(string IP)
		{
			return Regex.IsMatch(IP, "^((2[0-4]\\d|25[0-5]|[01]?\\d\\d?)\\.){3}(2[0-4]\\d|25[0-5]|[01]?\\d\\d?)$");
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000348C File Offset: 0x0000168C
		public static bool Letter(string str)
		{
			return Regex.IsMatch(str, "^[A-Za-z]+$");
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00003499 File Offset: 0x00001699
		public static bool LetterOrDigit(string str)
		{
			return Regex.IsMatch(str, "^[A-Za-z0-9]+$");
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000034A6 File Offset: 0x000016A6
		public static bool HexString(string str)
		{
			return Regex.IsMatch(str, "^[A-Fa-f0-9]+$");
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000034B3 File Offset: 0x000016B3
		public static bool KeyWord(string str)
		{
			return Regex.IsMatch(str, "^[\u3000， ,A-Za-z0-9\\u4e00-\\u9fa5]+$");
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000034C0 File Offset: 0x000016C0
		public static bool Number(string str)
		{
			return Regex.IsMatch(str, "^[0-9]+$");
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000034CD File Offset: 0x000016CD
		public static bool NumberSign(string str)
		{
			return Regex.IsMatch(str, "^[+-]?[0-9]+$");
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000034DA File Offset: 0x000016DA
		public static bool Date(string strDate)
		{
			return Regex.IsMatch(strDate, "^((((1[6-9]|[2-9]\\d)\\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\\d|3[01]))|(((1[6-9]|[2-9]\\d)\\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\\d|30))|(((1[6-9]|[2-9]\\d)\\d{2})-0?2-(0?[1-9]|1\\d|2[0-8]))|(((1[6-9]|[2-9]\\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$");
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000034E7 File Offset: 0x000016E7
		public static bool Time(string strTime)
		{
			return Regex.IsMatch(strTime, "^((([0-1]?[0-9])|(2[0-3])):([0-5]?[0-9])(:[0-5]?[0-9])?)$");
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000034F4 File Offset: 0x000016F4
		public static bool QQ(string strQQ)
		{
			return Regex.IsMatch(strQQ, "^[1-9]\\d{4,9}$");
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003501 File Offset: 0x00001701
		public static bool Phone(string strPhone)
		{
			return Regex.IsMatch(strPhone, "(\\d{3}-|\\d{4}-)?(\\d{8}|\\d{7})?");
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000350E File Offset: 0x0000170E
		public static bool Mobile(string mobile)
		{
			return Regex.IsMatch(mobile, "\\d{11}");
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000351B File Offset: 0x0000171B
		public static bool Contact(string str)
		{
			return Regex.IsMatch(str, "(\\d{11})|(((\\d{3}-|\\d{4}-)?(\\d{8}|\\d{7})?))");
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003528 File Offset: 0x00001728
		public static bool Chinese(string str)
		{
			return Regex.IsMatch(str, "^[一-龥]+$");
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00003535 File Offset: 0x00001735
		public static bool HasCHZN(string str)
		{
			return Regex.IsMatch(str, "[一-龥]");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00003542 File Offset: 0x00001742
		public static bool Price(string strPrice)
		{
			return Regex.IsMatch(strPrice, "^(([0-9]+\\.[0-9]*[0-9][0-9]*)|([0-9]*[1-9][0-9]*\\.[0-9]+)|([0-9]*[1-9][0-9]*))$");
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000354F File Offset: 0x0000174F
		public static bool UserName(string str)
		{
			return Regex.IsMatch(str, "^[A-Za-z0-9_]{4,10}$");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000355C File Offset: 0x0000175C
		public static bool PassWord(string str)
		{
			return Regex.IsMatch(str, "(.|\\s){4,10}");
		}
	}
}
