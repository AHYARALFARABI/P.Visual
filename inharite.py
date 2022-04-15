class toko():
    def __init__(self, nama, jenis, alamat):
        self.nama = nama
        self.jenis = jenis
        self.alamat = alamat

    def cek_id_toko(self):
        print('nama:',self.nama, '\njenis:',self.jenis, '\nalamat:',self.alamat)

class Tokoped(toko):
    def cek_id_toko(self):
        print('cek aja tokoped appssnya')

toko1 = toko('Verdy', 'sepatu', 'Majene')
toko2 = Tokoped('Senica', 'Bola', 'Makassar')

toko1.cek_id_toko()
toko2.cek_id_toko()