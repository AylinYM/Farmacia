using Farmacia.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy( policity =>
            {
                policity
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            }
        );
    }
);
var app = builder.Build();

app.UseCors();

app.MapGet("/",()=>
{
    return "API Farmacia funcionando";
});

var productos = new List<Producto>
    {
        new Producto {
            id=1,
            codigo="MED001",
            nombre="Paracetamol",
            categoria="Analgésico",
            principioActivo="Paracetamol",
            concentracion="500 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="Genfar",
            precio=8.50,
            stock=120,
            fechaVencimiento="2028-05-30",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Paracetamol_acetaminophen_500_mg_pills.jpg",
            descripcion="Analgésico y antipirético utilizado para aliviar el dolor y reducir la fiebre."
        },
        new Producto {
            id=2,
            codigo="MED002",
            nombre="Ibuprofeno",
            categoria="Antiinflamatorio",
            principioActivo="Ibuprofeno",
            concentracion="400 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="Genfar",
            precio=10.90,
            stock=95,
            fechaVencimiento="2028-07-15",
            descuento=10,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/200mg_ibuprofen_tablets.jpg",
            descripcion="Antiinflamatorio no esteroideo utilizado para aliviar dolor, inflamación y fiebre."
        },
        new Producto {
            id=3,
            codigo="MED003",
            nombre="Naproxeno",
            categoria="Antiinflamatorio",
            principioActivo="Naproxeno sódico",
            concentracion="550 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="Medifarma",
            precio=15.50,
            stock=70,
            fechaVencimiento="2028-08-20",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Naproxen.JPG",
            descripcion="Antiinflamatorio utilizado para aliviar dolor e inflamación."
        },
        new Producto {
            id=4,
            codigo="MED004",
            nombre="Diclofenaco",
            categoria="Antiinflamatorio",
            principioActivo="Diclofenaco sódico",
            concentracion="50 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="Novartis",
            precio=12.90,
            stock=85,
            fechaVencimiento="2028-03-12",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Diclofenac_Natrium_50mg_Aurobindo.jpg",
            descripcion="Antiinflamatorio utilizado para disminuir el dolor y la inflamación."
        },
        new Producto {
            id=5,
            codigo="MED005",
            nombre="Ketorolaco",
            categoria="Analgésico",
            principioActivo="Ketorolaco trometamina",
            concentracion="10 mg",
            presentacion="Caja x 10 tabletas",
            laboratorio="Medifarma",
            precio=12.50,
            stock=60,
            fechaVencimiento="2028-11-10",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Ketorolac.png",
            descripcion="Analgésico antiinflamatorio utilizado para el manejo del dolor."
        },
        new Producto {
            id=6,
            codigo="MED006",
            nombre="Amoxicilina",
            categoria="Antibiótico",
            principioActivo="Amoxicilina",
            concentracion="500 mg",
            presentacion="Caja x 21 cápsulas",
            laboratorio="Sandoz",
            precio=18.90,
            stock=75,
            fechaVencimiento="2028-06-18",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Amoxicillin_500mg_capsules_on_a_plate_(Sandoz).jpg",
            descripcion="Antibiótico del grupo de las penicilinas utilizado para determinadas infecciones bacterianas."
        },
        new Producto {
            id=7,
            codigo="MED007",
            nombre="Azitromicina",
            categoria="Antibiótico",
            principioActivo="Azitromicina",
            concentracion="500 mg",
            presentacion="Caja x 3 tabletas",
            laboratorio="Pfizer",
            precio=17.50,
            stock=45,
            fechaVencimiento="2028-09-25",
            descuento=8,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Zithromax_(Azithromycin)_tablets.jpg",
            descripcion="Antibiótico macrólido utilizado para determinadas infecciones bacterianas."
        },
        new Producto {
            id=8,
            codigo="MED008",
            nombre="Ciprofloxacino",
            categoria="Antibiótico",
            principioActivo="Ciprofloxacino",
            concentracion="500 mg",
            presentacion="Caja x 10 tabletas",
            laboratorio="Bayer",
            precio=19.90,
            stock=40,
            fechaVencimiento="2028-04-14",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Ciprofloxacin.jpg",
            descripcion="Antibiótico fluoroquinolona utilizado para determinadas infecciones bacterianas."
        },
        new Producto {
            id=9,
            codigo="MED009",
            nombre="Cefalexina",
            categoria="Antibiótico",
            principioActivo="Cefalexina",
            concentracion="500 mg",
            presentacion="Caja x 20 cápsulas",
            laboratorio="Genfar",
            precio=22.50,
            stock=55,
            fechaVencimiento="2028-10-08",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Cephalexin_capsules.jpg",
            descripcion="Antibiótico cefalosporínico utilizado para determinadas infecciones bacterianas."
        },
        new Producto {
            id=10,
            codigo="MED010",
            nombre="Claritromicina",
            categoria="Antibiótico",
            principioActivo="Claritromicina",
            concentracion="500 mg",
            presentacion="Caja x 10 tabletas",
            laboratorio="Abbott",
            precio=28.90,
            stock=35,
            fechaVencimiento="2028-12-20",
            descuento=10,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Clarithromycin_caplets.jpg",
            descripcion="Antibiótico macrólido empleado para determinadas infecciones bacterianas."
        },

        new Producto {
            id=11,
            codigo="MED011",
            nombre="Loratadina",
            categoria="Antihistamínico",
            principioActivo="Loratadina",
            concentracion="10 mg",
            presentacion="Caja x 10 tabletas",
            laboratorio="Bayer",
            precio=7.50,
            stock=100,
            fechaVencimiento="2029-01-15",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Comprimidos_de_Loratadina.jpg",
            descripcion="Antihistamínico utilizado para aliviar síntomas de alergia."
        },
        new Producto {
            id=12,
            codigo="MED012",
            nombre="Cetirizina",
            categoria="Antihistamínico",
            principioActivo="Cetirizina",
            concentracion="10 mg",
            presentacion="Caja x 10 tabletas",
            laboratorio="UCB",
            precio=8.90,
            stock=90,
            fechaVencimiento="2028-06-30",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Cetirizine_tablets_under_the_brand_name_«Зодак».jpg",
            descripcion="Antihistamínico empleado para aliviar diferentes síntomas de alergia."
        },
        new Producto {
            id=13,
            codigo="MED013",
            nombre="Fexofenadina",
            categoria="Antihistamínico",
            principioActivo="Fexofenadina",
            concentracion="120 mg",
            presentacion="Caja x 10 tabletas",
            laboratorio="Sanofi",
            precio=24.90,
            stock=40,
            fechaVencimiento="2028-09-18",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Fexofenadine.svg",
            descripcion="Antihistamínico utilizado para tratar síntomas asociados con alergias."
        },
        new Producto {
            id=14,
            codigo="MED014",
            nombre="Omeprazol",
            categoria="Gastrointestinal",
            principioActivo="Omeprazol",
            concentracion="20 mg",
            presentacion="Caja x 14 cápsulas",
            laboratorio="Actavis",
            precio=9.50,
            stock=110,
            fechaVencimiento="2028-07-21",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Omeprazol_Activis_capsules.jpg",
            descripcion="Inhibidor de la bomba de protones que disminuye la producción de ácido gástrico."
        },
        new Producto {
            id=15,
            codigo="MED015",
            nombre="Pantoprazol",
            categoria="Gastrointestinal",
            principioActivo="Pantoprazol",
            concentracion="40 mg",
            presentacion="Caja x 14 tabletas",
            laboratorio="Takeda",
            precio=16.90,
            stock=65,
            fechaVencimiento="2028-10-12",
            descuento=10,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Pantoprazole_20mg.jpg",
            descripcion="Medicamento utilizado para disminuir la producción de ácido gástrico."
        },
        new Producto {
            id=16,
            codigo="MED016",
            nombre="Esomeprazol",
            categoria="Gastrointestinal",
            principioActivo="Esomeprazol",
            concentracion="20 mg",
            presentacion="Caja x 14 cápsulas",
            laboratorio="AstraZeneca",
            precio=29.90,
            stock=45,
            fechaVencimiento="2029-02-15",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Esomeprazole.jpg",
            descripcion="Medicamento utilizado para reducir la producción de ácido del estómago."
        },
        new Producto {
            id=17,
            codigo="MED017",
            nombre="Metoclopramida",
            categoria="Antiemético",
            principioActivo="Metoclopramida",
            concentracion="10 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="Sanofi",
            precio=8.50,
            stock=70,
            fechaVencimiento="2028-08-05",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Maxolon,_Metoclopramide_Hydrochloride_Anhydrous_10MG_Tablet,_Box,_Tablet_Sheet.jpg",
            descripcion="Medicamento utilizado para determinadas situaciones de náuseas y vómitos."
        },
        new Producto {
            id=18,
            codigo="MED018",
            nombre="Ondansetrón",
            categoria="Antiemético",
            principioActivo="Ondansetrón",
            concentracion="8 mg",
            presentacion="Caja x 10 tabletas",
            laboratorio="GSK",
            precio=26.90,
            stock=30,
            fechaVencimiento="2028-11-30",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Tabletas.jpg",
            descripcion="Antiemético utilizado para prevenir o controlar náuseas y vómitos."
        },
        new Producto {
            id=19,
            codigo="MED019",
            nombre="Loperamida",
            categoria="Antidiarreico",
            principioActivo="Loperamida",
            concentracion="2 mg",
            presentacion="Caja x 12 cápsulas",
            laboratorio="Janssen",
            precio=7.90,
            stock=80,
            fechaVencimiento="2028-05-19",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Loperamide.svg",
            descripcion="Medicamento utilizado para el control sintomático de determinados cuadros de diarrea."
        },
        new Producto {
            id=20,
            codigo="MED020",
            nombre="Simeticona",
            categoria="Gastrointestinal",
            principioActivo="Simeticona",
            concentracion="80 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="Medifarma",
            precio=11.50,
            stock=75,
            fechaVencimiento="2028-09-09",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Simethiconetablets.jpg",
            descripcion="Medicamento empleado para aliviar molestias relacionadas con gases intestinales."
        },

        new Producto {
            id=21,
            codigo="MED021",
            nombre="Losartán",
            categoria="Antihipertensivo",
            principioActivo="Losartán potásico",
            concentracion="50 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Merck",
            precio=18.50,
            stock=85,
            fechaVencimiento="2028-12-10",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Losartan_potassium1.jpg",
            descripcion="Antihipertensivo utilizado para controlar la presión arterial."
        },
        new Producto {
            id=22,
            codigo="MED022",
            nombre="Enalapril",
            categoria="Antihipertensivo",
            principioActivo="Enalapril maleato",
            concentracion="10 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Merck",
            precio=12.90,
            stock=90,
            fechaVencimiento="2028-10-20",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Enalapril.png",
            descripcion="Medicamento utilizado para el tratamiento de la hipertensión arterial."
        },
        new Producto {
            id=23,
            codigo="MED023",
            nombre="Amlodipino",
            categoria="Antihipertensivo",
            principioActivo="Amlodipino",
            concentracion="5 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Pfizer",
            precio=14.50,
            stock=75,
            fechaVencimiento="2029-01-10",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Amlodipine.svg",
            descripcion="Bloqueador de canales de calcio utilizado para controlar la presión arterial."
        },
        new Producto {
            id=24,
            codigo="MED024",
            nombre="Atenolol",
            categoria="Antihipertensivo",
            principioActivo="Atenolol",
            concentracion="50 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="AstraZeneca",
            precio=11.90,
            stock=55,
            fechaVencimiento="2028-08-17",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Atenolol_tablets_(UK).jpg",
            descripcion="Betabloqueador utilizado para determinadas enfermedades cardiovasculares."
        },
        new Producto {
            id=25,
            codigo="MED025",
            nombre="Carvedilol",
            categoria="Cardiovascular",
            principioActivo="Carvedilol",
            concentracion="12.5 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Roche",
            precio=21.90,
            stock=45,
            fechaVencimiento="2028-11-25",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Carvedilol_tablets.jpg",
            descripcion="Medicamento cardiovascular utilizado para determinadas afecciones cardíacas."
        },
        new Producto {
            id=26,
            codigo="MED026",
            nombre="Atorvastatina",
            categoria="Hipolipemiante",
            principioActivo="Atorvastatina",
            concentracion="20 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Pfizer",
            precio=27.90,
            stock=60,
            fechaVencimiento="2029-03-10",
            descuento=10,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Atorvastatin40mg.jpg",
            descripcion="Estatina utilizada para ayudar a controlar determinados niveles de colesterol."
        },
        new Producto {
            id=27,
            codigo="MED027",
            nombre="Rosuvastatina",
            categoria="Hipolipemiante",
            principioActivo="Rosuvastatina",
            concentracion="10 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="AstraZeneca",
            precio=32.50,
            stock=45,
            fechaVencimiento="2029-04-20",
            descuento=10,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Crestor_Tablets_(rosuvastatin).jpg",
            descripcion="Medicamento empleado para controlar determinados niveles elevados de colesterol."
        },
        new Producto {
            id=28,
            codigo="MED028",
            nombre="Metformina",
            categoria="Antidiabético",
            principioActivo="Metformina clorhidrato",
            concentracion="850 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Merck",
            precio=16.90,
            stock=100,
            fechaVencimiento="2028-09-15",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Metformin_500mg_Tablets.jpg",
            descripcion="Antidiabético oral utilizado en el manejo de la diabetes mellitus tipo 2."
        },
        new Producto {
            id=29,
            codigo="MED029",
            nombre="Glibenclamida",
            categoria="Antidiabético",
            principioActivo="Glibenclamida",
            concentracion="5 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Sanofi",
            precio=12.50,
            stock=65,
            fechaVencimiento="2028-07-12",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Glibenclamide_tablets.jpg",
            descripcion="Antidiabético oral utilizado para ayudar a controlar la glucemia."
        },
        new Producto {
            id=30,
            codigo="MED030",
            nombre="Sitagliptina",
            categoria="Antidiabético",
            principioActivo="Sitagliptina",
            concentracion="100 mg",
            presentacion="Caja x 28 tabletas",
            laboratorio="MSD",
            precio=85.90,
            stock=25,
            fechaVencimiento="2029-05-10",
            descuento=10,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Sitagliptin_tablets.jpg",
            descripcion="Medicamento utilizado en determinados pacientes con diabetes mellitus tipo 2."
        },

        new Producto {
            id=31,
            codigo="MED031",
            nombre="Salbutamol",
            categoria="Respiratorio",
            principioActivo="Salbutamol",
            concentracion="100 mcg/dosis",
            presentacion="Inhalador x 200 dosis",
            laboratorio="GSK",
            precio=24.90,
            stock=50,
            fechaVencimiento="2028-12-15",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Salbutamol2.JPG",
            descripcion="Broncodilatador inhalado utilizado para aliviar determinados episodios de broncoespasmo."
        },
        new Producto {
            id=32,
            codigo="MED032",
            nombre="Budesonida",
            categoria="Respiratorio",
            principioActivo="Budesonida",
            concentracion="200 mcg",
            presentacion="Inhalador",
            laboratorio="AstraZeneca",
            precio=48.90,
            stock=30,
            fechaVencimiento="2029-01-25",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Easyhaler_Budesonid_inhaler.jpg",
            descripcion="Corticosteroide inhalado utilizado para controlar la inflamación de las vías respiratorias."
        },
        new Producto {
            id=33,
            codigo="MED033",
            nombre="Ambroxol",
            categoria="Mucolítico",
            principioActivo="Ambroxol",
            concentracion="30 mg/5 ml",
            presentacion="Jarabe x 120 ml",
            laboratorio="Boehringer Ingelheim",
            precio=16.50,
            stock=55,
            fechaVencimiento="2028-10-10",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Ambroxol-HCl_substance_photo.jpg",
            descripcion="Mucolítico utilizado para facilitar la eliminación de secreciones respiratorias."
        },
        new Producto {
            id=34,
            codigo="MED034",
            nombre="Acetilcisteína",
            categoria="Mucolítico",
            principioActivo="Acetilcisteína",
            concentracion="600 mg",
            presentacion="Caja x 10 sobres",
            laboratorio="Zambon",
            precio=29.90,
            stock=40,
            fechaVencimiento="2028-11-19",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Acetylcystein_as_effervescent_tablet_branded_ACC_by_Sandoz.jpg",
            descripcion="Mucolítico utilizado para disminuir la viscosidad de las secreciones respiratorias."
        },
        new Producto {
            id=35,
            codigo="MED035",
            nombre="Dextrometorfano",
            categoria="Antitusivo",
            principioActivo="Dextrometorfano",
            concentracion="15 mg/5 ml",
            presentacion="Jarabe x 120 ml",
            laboratorio="Medifarma",
            precio=14.90,
            stock=60,
            fechaVencimiento="2028-06-22",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Dextromethorphan.jpg",
            descripcion="Antitusivo utilizado para aliviar determinados cuadros de tos seca."
        },
        new Producto {
            id=36,
            codigo="MED036",
            nombre="Clotrimazol",
            categoria="Antifúngico",
            principioActivo="Clotrimazol",
            concentracion="1%",
            presentacion="Crema x 20 g",
            laboratorio="Bayer",
            precio=15.90,
            stock=70,
            fechaVencimiento="2028-09-16",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Clotrimazole.png",
            descripcion="Antifúngico tópico utilizado para determinadas infecciones causadas por hongos."
        },
        new Producto {
            id=37,
            codigo="MED037",
            nombre="Fluconazol",
            categoria="Antifúngico",
            principioActivo="Fluconazol",
            concentracion="150 mg",
            presentacion="Caja x 1 cápsula",
            laboratorio="Pfizer",
            precio=10.90,
            stock=65,
            fechaVencimiento="2028-12-12",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Fluconazole_capsules.jpg",
            descripcion="Antifúngico sistémico utilizado para determinadas infecciones por hongos."
        },
        new Producto {
            id=38,
            codigo="MED038",
            nombre="Terbinafina",
            categoria="Antifúngico",
            principioActivo="Terbinafina",
            concentracion="1%",
            presentacion="Crema x 15 g",
            laboratorio="Novartis",
            precio=22.90,
            stock=40,
            fechaVencimiento="2029-02-14",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Terbinafine_cream.jpg",
            descripcion="Antifúngico tópico utilizado en determinadas infecciones de la piel."
        },
        new Producto {
            id=39,
            codigo="MED039",
            nombre="Aciclovir",
            categoria="Antiviral",
            principioActivo="Aciclovir",
            concentracion="400 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="GSK",
            precio=28.50,
            stock=35,
            fechaVencimiento="2028-08-30",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Acyclovir_pills.jpg",
            descripcion="Antiviral utilizado para determinadas infecciones producidas por herpesvirus."
        },
        new Producto {
            id=40,
            codigo="MED040",
            nombre="Hidrocortisona",
            categoria="Corticoide",
            principioActivo="Hidrocortisona",
            concentracion="1%",
            presentacion="Crema x 20 g",
            laboratorio="Pfizer",
            precio=13.90,
            stock=55,
            fechaVencimiento="2028-07-18",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Tube_of_hydrocortisone_cream.jpg",
            descripcion="Corticosteroide tópico utilizado para disminuir determinadas reacciones inflamatorias."
        },

        new Producto {
            id=41,
            codigo="MED041",
            nombre="Prednisona",
            categoria="Corticoide",
            principioActivo="Prednisona",
            concentracion="20 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="Genfar",
            precio=14.50,
            stock=50,
            fechaVencimiento="2028-11-11",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Prednisone_20mg_(TL_175)_corticosteroid_medication_pills_(55006378950).jpg",
            descripcion="Corticosteroide sistémico utilizado en diferentes procesos inflamatorios."
        },
        new Producto {
            id=42,
            codigo="MED042",
            nombre="Dexametasona",
            categoria="Corticoide",
            principioActivo="Dexametasona",
            concentracion="4 mg",
            presentacion="Caja x 20 tabletas",
            laboratorio="Merck",
            precio=12.90,
            stock=45,
            fechaVencimiento="2028-10-05",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Dexamethasone_tablets.jpg",
            descripcion="Corticosteroide utilizado para determinadas afecciones inflamatorias."
        },
        new Producto {
            id=43,
            codigo="MED043",
            nombre="Levotiroxina",
            categoria="Hormonal",
            principioActivo="Levotiroxina sódica",
            concentracion="100 mcg",
            presentacion="Caja x 50 tabletas",
            laboratorio="Merck",
            precio=32.90,
            stock=55,
            fechaVencimiento="2029-04-18",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Levothyroxine_25mcg_Tablets.jpg",
            descripcion="Hormona tiroidea sintética utilizada en el tratamiento del hipotiroidismo."
        },
        new Producto {
            id=44,
            codigo="MED044",
            nombre="Ácido fólico",
            categoria="Vitamina",
            principioActivo="Ácido fólico",
            concentracion="1 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Medifarma",
            precio=7.50,
            stock=120,
            fechaVencimiento="2029-05-25",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Фолиевая_кислота_в_таблетках.jpg",
            descripcion="Vitamina B9 utilizada como suplemento nutricional."
        },
        new Producto {
            id=45,
            codigo="MED045",
            nombre="Vitamina C",
            categoria="Vitamina",
            principioActivo="Ácido ascórbico",
            concentracion="500 mg",
            presentacion="Frasco x 30 tabletas",
            laboratorio="Bayer",
            precio=15.90,
            stock=100,
            fechaVencimiento="2029-06-20",
            descuento=10,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Vitamin_C_Tablets.jpg",
            descripcion="Suplemento utilizado como fuente de vitamina C."
        },
        new Producto {
            id=46,
            codigo="MED046",
            nombre="Vitamina D3",
            categoria="Vitamina",
            principioActivo="Colecalciferol",
            concentracion="1000 UI",
            presentacion="Frasco x 60 cápsulas",
            laboratorio="Nature Made",
            precio=29.90,
            stock=65,
            fechaVencimiento="2029-08-10",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Vitamin_D3_capsules.jpg",
            descripcion="Suplemento utilizado como fuente adicional de vitamina D3."
        },
        new Producto {
            id=47,
            codigo="MED047",
            nombre="Complejo B",
            categoria="Vitamina",
            principioActivo="Vitaminas del complejo B",
            concentracion="Multivitamínico",
            presentacion="Caja x 30 tabletas",
            laboratorio="Bayer",
            precio=18.50,
            stock=75,
            fechaVencimiento="2029-03-22",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Vitamin_B_complex_tablets.jpg",
            descripcion="Suplemento que contiene diferentes vitaminas pertenecientes al complejo B."
        },
        new Producto {
            id=48,
            codigo="MED048",
            nombre="Sulfato ferroso",
            categoria="Suplemento",
            principioActivo="Sulfato ferroso",
            concentracion="300 mg",
            presentacion="Caja x 30 tabletas",
            laboratorio="Medifarma",
            precio=10.90,
            stock=80,
            fechaVencimiento="2029-02-10",
            descuento=0,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/RECALLED_–_Ferrous_Sulfate_Tablets,_325_mg_(8391322734).jpg",
            descripcion="Suplemento de hierro utilizado para determinadas deficiencias de hierro."
        },
        new Producto {
            id=49,
            codigo="MED049",
            nombre="Carbonato de calcio",
            categoria="Suplemento",
            principioActivo="Carbonato de calcio",
            concentracion="500 mg",
            presentacion="Frasco x 60 tabletas",
            laboratorio="Medifarma",
            precio=19.90,
            stock=70,
            fechaVencimiento="2029-07-15",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Calcium_carbonate_tablets.jpg",
            descripcion="Suplemento utilizado como fuente adicional de calcio."
        },
        new Producto {
            id=50,
            codigo="MED050",
            nombre="Magnesio",
            categoria="Suplemento",
            principioActivo="Óxido de magnesio",
            concentracion="400 mg",
            presentacion="Frasco x 60 tabletas",
            laboratorio="Nature Made",
            precio=26.90,
            stock=60,
            fechaVencimiento="2029-09-12",
            descuento=5,
            imagen="https://commons.wikimedia.org/wiki/Special:Redirect/file/Magnesium_oxide_tablets.jpg",
            descripcion="Suplemento mineral utilizado como fuente adicional de magnesio."
        }
    };

var categorias = new List<Categoria>
{
    new Categoria { id = 1, nombre = "Analgésico", descripcion = "Medicamentos utilizados para aliviar el dolor." },

    new Categoria { id = 2, nombre = "Antibiótico", descripcion = "Medicamentos utilizados para tratar infecciones bacterianas." },

    new Categoria { id = 3, nombre = "Antidiabético", descripcion = "Medicamentos utilizados para el control de la diabetes." },

    new Categoria { id = 4, nombre = "Antidiarreico", descripcion = "Medicamentos utilizados para el tratamiento de la diarrea." },

    new Categoria { id = 5, nombre = "Antiemético", descripcion = "Medicamentos utilizados para prevenir o controlar las náuseas y vómitos." },

    new Categoria { id = 6, nombre = "Antifúngico", descripcion = "Medicamentos utilizados para tratar infecciones causadas por hongos." },

    new Categoria { id = 7, nombre = "Antihipertensivo", descripcion = "Medicamentos utilizados para ayudar a controlar la presión arterial." },

    new Categoria { id = 8, nombre = "Antihistamínico", descripcion = "Medicamentos utilizados para aliviar síntomas relacionados con alergias." },

    new Categoria { id = 9, nombre = "Antiinflamatorio", descripcion = "Medicamentos utilizados para reducir la inflamación y aliviar el dolor." },

    new Categoria { id = 10, nombre = "Antitusivo", descripcion = "Medicamentos utilizados para aliviar o controlar la tos." },

    new Categoria { id = 11, nombre = "Antiviral", descripcion = "Medicamentos utilizados para el tratamiento de determinadas infecciones virales." },

    new Categoria { id = 12, nombre = "Cardiovascular", descripcion = "Medicamentos relacionados con el tratamiento y cuidado del sistema cardiovascular." },

    new Categoria { id = 13, nombre = "Corticoide", descripcion = "Medicamentos utilizados en distintos procesos inflamatorios y otras condiciones médicas." },

    new Categoria { id = 14, nombre = "Gastrointestinal", descripcion = "Medicamentos destinados al tratamiento de diferentes trastornos del sistema digestivo." },

    new Categoria { id = 15, nombre = "Hipolipemiante", descripcion = "Medicamentos utilizados para ayudar a controlar los niveles de lípidos en la sangre." },

    new Categoria { id = 16, nombre = "Hormonal", descripcion = "Medicamentos relacionados con tratamientos hormonales." },

    new Categoria { id = 17, nombre = "Mucolítico", descripcion = "Medicamentos utilizados para facilitar la eliminación de secreciones respiratorias." },

    new Categoria { id = 18, nombre = "Respiratorio", descripcion = "Medicamentos destinados al tratamiento de diferentes afecciones respiratorias." },

    new Categoria { id = 19, nombre = "Suplemento", descripcion = "Productos utilizados para complementar la alimentación y el aporte de determinados nutrientes." },

    new Categoria { id = 20, nombre = "Vitamina", descripcion = "Productos destinados a complementar el aporte de vitaminas al organismo." }
};

var laboratorios = new List<Laboratorio>
{
    new Laboratorio { id = 1, nombre = "Abbott" },
    new Laboratorio { id = 2, nombre = "Actavis" },
    new Laboratorio { id = 3, nombre = "AstraZeneca" },
    new Laboratorio { id = 4, nombre = "Bayer" },
    new Laboratorio { id = 5, nombre = "Boehringer Ingelheim" },
    new Laboratorio { id = 6, nombre = "GSK" },
    new Laboratorio { id = 7, nombre = "Genfar" },
    new Laboratorio { id = 8, nombre = "Janssen" },
    new Laboratorio { id = 9, nombre = "MSD" },
    new Laboratorio { id = 10, nombre = "Medifarma" },
    new Laboratorio { id = 11, nombre = "Merck" },
    new Laboratorio { id = 12, nombre = "Nature Made" },
    new Laboratorio { id = 13, nombre = "Novartis" },
    new Laboratorio { id = 14, nombre = "Pfizer" },
    new Laboratorio { id = 15, nombre = "Roche" },
    new Laboratorio { id = 16, nombre = "Sandoz" },
    new Laboratorio { id = 17, nombre = "Sanofi" },
    new Laboratorio { id = 18, nombre = "Takeda" },
    new Laboratorio { id = 19, nombre = "UCB" },
    new Laboratorio { id = 20, nombre = "Zambon" }
};

var promociones = new List<Promocion>
{
    new Promocion
    {
        id = 1,
        nombre = "Descuento del 10%",
        descripcion = "Promoción en medicamentos seleccionados.",
        descuento = 10,
        activa = true
    },
    new Promocion
    {
        id = 2,
        nombre = "Descuento del 5%",
        descripcion = "Descuento especial en productos seleccionados.",
        descuento = 5,
        activa = true
    },
    new Promocion
    {
        id = 3,
        nombre = "Campaña de salud",
        descripcion = "Promoción especial disponible por tiempo limitado.",
        descuento = 15,
        activa = true
    }
};


app.MapGet("/api/farmacia", () =>
{
    return Results.Ok(productos);
});

app.MapGet("/api/farmacia/{id}", (int id) =>
{
    var producto = productos.FirstOrDefault(p => p.id == id);

    if (producto == null)
        return Results.NotFound();

    return Results.Ok(producto);
});

app.MapPost("/api/farmacia", (Producto producto) =>
{
    producto.id = productos.Count == 0
        ? 1
        : productos.Max(p => p.id) + 1;

    productos.Add(producto);

    return Results.Created($"/api/farmacia/{producto.id}", producto);
});

app.MapPut("/api/farmacia/{id}", (int id, Producto actualizado) =>
{
    var producto = productos.FirstOrDefault(p => p.id == id);

    if (producto == null)
        return Results.NotFound();

    producto.codigo = actualizado.codigo;
    producto.nombre = actualizado.nombre;
    producto.categoria = actualizado.categoria;
    producto.principioActivo = actualizado.principioActivo;
    producto.concentracion = actualizado.concentracion;
    producto.presentacion = actualizado.presentacion;
    producto.laboratorio = actualizado.laboratorio;
    producto.precio = actualizado.precio;
    producto.stock = actualizado.stock;
    producto.fechaVencimiento = actualizado.fechaVencimiento;
    producto.descuento = actualizado.descuento;
    producto.imagen = actualizado.imagen;
    producto.descripcion = actualizado.descripcion;

    return Results.Ok(producto);
});

app.MapDelete("/api/farmacia/{id}", (int id) =>
{
    var producto = productos.FirstOrDefault(p => p.id == id);

    if (producto == null)
        return Results.NotFound();

    productos.Remove(producto);

    return Results.NoContent();
});

// =============================
// CATEGORIAS
// =============================

app.MapGet("/api/categorias", () =>
{
    return Results.Ok(categorias);
});

app.MapGet("/api/categorias/{id}", (int id) =>
{
    var categoria = categorias.FirstOrDefault(c => c.id == id);

    if (categoria == null)
        return Results.NotFound(new { mensaje = "Categoría no encontrada" });

    return Results.Ok(categoria);
});


// =============================
// LABORATORIOS
// =============================

app.MapGet("/api/laboratorios", () =>
{
    return Results.Ok(laboratorios);
});

app.MapGet("/api/laboratorios/{id}", (int id) =>
{
    var laboratorio = laboratorios.FirstOrDefault(l => l.id == id);

    if (laboratorio == null)
        return Results.NotFound(new { mensaje = "Laboratorio no encontrado" });

    return Results.Ok(laboratorio);
});


// =============================
// PROMOCIONES
// =============================

app.MapGet("/api/promociones", () =>
{
    return Results.Ok(promociones);
});

app.MapGet("/api/promociones/{id}", (int id) =>
{
    var promocion = promociones.FirstOrDefault(p => p.id == id);

    if (promocion == null)
        return Results.NotFound(new { mensaje = "Promoción no encontrada" });

    return Results.Ok(promocion);
});

var port = Environment.GetEnvironmentVariable("Port")??"10000";
app.Run($"http://0.0.0.0:(port)");
