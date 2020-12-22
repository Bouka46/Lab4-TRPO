

1) ----------------------------------------------------------------------------------------------
private void set_mode(bool mod)
{
  if (mod)
  {
    label1.Enabled = mod;
    button1.Enabled = mod;
    button2.Enabled = mod;
    button3.Enabled = !mod;
    button4.Enabled = !mod;
  }
  else
  {
    label1.Enabled = !mod;
    button1.Enabled = !mod;
    button2.Enabled = !mod;
    button3.Enabled = mod;
    button4.Enabled = mod;
  }
}
2) ----------------------------------------------------------------------------------------------
 switch (driver.Status)
{
  case ClientStatus.Unknown:
  case ClientStatus.Free:
  case ClientStatus.Busy:
  case ClientStatus.InWay:
  case ClientStatus.Work:
  case ClientStatus.Break:
  case ClientStatus.Alarm:
      return m_driverStatusNames[driver.Status];
}
3) ----------------------------------------------------------------------------------------------
uint i;
…
if (i < 10)
{
  ...
}
4) ----------------------------------------------------------------------------------------------
 string destination = String.Join('', source); string destination = null;

5) ----------------------------------------------------------------------------------------------
 Bool IsNumber(string str) {
  int number = 0;
  return TryParse(str, out x);}

6) ----------------------------------------------------------------------------------------------
 foreach (DirectoryInfo dir in dirs.GetDirectories())
{
  //create folder{16}
  stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
  stream.Read(new byte[1], 0, 1);
  stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length), 0, 4);
  stream.Write(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')), 0, Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length);
  //send folder name
  stream.Read(new byte[1], 0, 1);
}
7) ----------------------------------------------------------------------------------------------

String[] days = new String[7]{"Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday","Sunday"}

8) ----------------------------------------------------------------------------------------------
    Console.WriteLine($"--{DateTime.Now.ToLongTimeString()}--");
9) ----------------------------------------------------------------------------------------------
return (Counter % 1 != 0 && Counter != 0);

10) ----------------------------------------------------------------------------------------------
if (Connected != 0))
    rez = setup();
fl_end = true;

11) ----------------------------------------------------------------------------------------------
List<int> arr = new List<int>();
for (int i = 0; i < arr.Count; i++)
{
  if (arr[i] > 100)
    arr.Remove(arr[i]);
}
12) ----------------------------------------------------------------------------------------------
if (form.Keys.Length >= 0) throw Exception;
13) ----------------------------------------------------------------------------------------------

string[] nameParts = customer.Name.Split(' ');
string firstName = nameParts[0];
string lastName = nameParts[1];
14) ----------------------------------------------------------------------------------------------
foreach (string id in sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
{
  sourceId = Convert.ToInt32(id);
  break;
}
15) ----------------------------------------------------------------------------------------------
public string generateEMail()
{
  string res = PersonName.Replace(' ', '.');
  res += "@domain.ua";
  return res;
 
  
 16) ----------------------------------------------------------------------------------------------
foreach (string id in sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
{
  sourceId = Convert.ToInt32(id);
  break;
}
17) ----------------------------------------------------------------------------------------------
string GetTextDiv2(string text)
 {
  int mid = text.Length / 2;
  int r = text.IndexOf(" ", mid); if (r < 0) r = 5000;
  int l = text.IndexOf(" ", 0, mid); if (l < 0) l = 5000;
  if (r - mid > mid - l) 
    mid = l;
  else mid = r;
  if (mid == 5000) return "&nbsp" + text;
  return "&nbsp" + text.Substring(0, mid) + " <br/>&nbsp" +
 text.Substring(mid, text.Length - mid);
}
18) ----------------------------------------------------------------------------------------------
private static readonly char SPECIFIER = '$';
private static readonly char DELIMITER = ':';
private static readonly char[] DELIMITER_ARRAY = { DELIMITER };
19) ----------------------------------------------------------------------------------------------
  string mail = Config.GetSetting("AdminNotifications_EmailAddress");

if (mail.isEmpty())
    string mailTo = Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0));
 mailTo = mail;

20) ----------------------------------------------------------------------------------------------
public bool CheckPath(string path)
{
  int n;
  n = 0;
  switch (switch_on)
  {

    //Проверяем наличие нужных папок;
    case Directory.Exists(path + "SCLAD"):
    case Directory.Exists(path + "REAL"):
    case Directory.Exists(path + "DOSTAVKA"):
      n += 1;
  }
  //Проверяем наличие нужных файлов

  switch (switch_on)
  {
    case File.Exists(path + "analit.dbf"):
    case File.Exists(path + "partner.dbf"):
    case File.Exists(path + "SCLAD\\mdoc.dbf"):
    case File.Exists(path + "SCLAD\\mdoc.fpt"):
    case File.Exists(path + "SCLAD\\mdocm.dbf"):
    case File.Exists(path + "SCLAD\\mgrup.dbf"):
    case File.Exists(path + "SCLAD\\mlabel.dbf"):
    case File.Exists(path + "SCLAD\\mlabel.fpt"):
    case File.Exists(path + "REAL\\rbookm.dbf"):
    case File.Exists(path + "REAL\\rbook.dbf"):
    case File.Exists(path + "REAL\\rbook.fpt"):
    case File.Exists(path + "DOSTAVKA\\avt.dbf"):
    case File.Exists(path + "DOSTAVKA\\avtm.dbf"):
    case File.Exists(path + "DOSTAVKA\\avtm.fpt"):
    case File.Exists(path + "DOSTAVKA\\cargo.dbf"):
    case File.Exists(path + "DOSTAVKA\\cargom.dbf"):
    case File.Exists(path + "DOSTAVKA\\zamena.dbf"):
      n += 1;
  }
        //Если указанная папка содержит все, что нужно
  if (n == 20)
  {
    return true;
  }
  return false;
}
21) ----------------------------------------------------------------------------------------------
txtContacts.Text = ";" + String.Join('', conctacts);
22) ----------------------------------------------------------------------------------------------
  var clou = Game1.clou;
if (clou == true)
  clou = !clou;
else
{
  clou = !clou
}