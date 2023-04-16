namespace TP_MOD9_KPL_1302210106
{
    public class Mahasiswa
    {
        public string Nama { get; private set; }
        public string Nim  { get; private set; }

        public Mahasiswa(string nama, string nim)
        {
            this.Nama = nama;
            this.Nim = nim;
        }
    }
}
