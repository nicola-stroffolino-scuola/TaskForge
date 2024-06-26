using System.ComponentModel.DataAnnotations;

namespace TaskForge.Models;

public class Register {
    // [Required] -> During Form Validation
    //  required  -> During Instance Creation
    [Required]
    public required string Name { get; set; }
    
    [Required]
    public required string Surname { get; set; }

    [Required]
    public required string Username { get; set; }
    
    [Required]
    [DataType(DataType.EmailAddress)]
    public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [Compare("Password", ErrorMessage = "Passwords don't match.")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public required string ConfirmPassword { get; set; }

    [Required]
    public required Gender Gender { get; set; }

    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Date of Birth")]
    public required DateOnly DateOfBirth { get; set; }
    
    [Required]
    public required Nationality Nationality { get; set; }
    
    [Required]
    public required List<Language> Languages { get; set; }
}

public enum Gender {
    Male,
    Female,
    Rather_Not_Say
}

public enum Nationality
{
    Afghan,
    Albanian,
    Algerian,
    American,
    Andorran,
    Angolan,
    Antiguans_and_Barbudans,
    Argentinean,
    Armenian,
    Australian,
    Austrian,
    Azerbaijani,
    Bahamian,
    Bahraini,
    Bangladeshi,
    Barbadian,
    Belarusian,
    Belgian,
    Belizean,
    Beninese,
    Bhutanese,
    Bolivian,
    Bosnian,
    Brazilian,
    British,
    Bruneian,
    Bulgarian,
    Burkinabe,
    Burmese,
    Burundian,
    Cambodian,
    Cameroonian,
    Canadian,
    Cape_Verdean,
    Central_African,
    Chadian,
    Chilean,
    Chinese,
    Colombian,
    Comoran,
    Congolese,
    Costa_Rican,
    Croatian,
    Cuban,
    Cypriot,
    Czech,
    Danish,
    Djibouti,
    Dominican,
    Dutch,
    East_Timorese,
    Ecuadorean,
    Egyptian,
    Emirian,
    Equatorial_Guinean,
    Eritrean,
    Estonian,
    Ethiopian,
    Fijian,
    Filipino,
    Finnish,
    French,
    Gabonese,
    Gambian,
    Georgian,
    German,
    Ghanaian,
    Greek,
    Grenadian,
    Guatemalan,
    Guinean,
    Guyanese,
    Haitian,
    Herzegovinian,
    Honduran,
    Hungarian,
    Icelander,
    Indian,
    Indonesian,
    Iranian,
    Iraqi,
    Irish,
    Israeli,
    Italian,
    Ivorian,
    Jamaican,
    Japanese,
    Jordanian,
    Kazakhstani,
    Kenyan,
    Kittian_and_Nevisian,
    Kuwaiti,
    Kyrgyz,
    Laotian,
    Latvian,
    Lebanese,
    Liberian,
    Libyan,
    Liechtensteiner,
    Lithuanian,
    Luxembourger,
    Macedonian,
    Malagasy,
    Malawian,
    Malaysian,
    Maldivian,
    Malian,
    Maltese,
    Marshallese,
    Mauritanian,
    Mauritian,
    Mexican,
    Micronesian,
    Moldovan,
    Monacan,
    Mongolian,
    Moroccan,
    Mosotho,
    Motswana,
    Mozambican,
    Namibian,
    Nauruan,
    Nepalese,
    New_Zealander,
    Nicaraguan,
    Nigerian,
    Nigerien,
    North_Korean,
    Northern_Irish,
    Norwegian,
    Omani,
    Pakistani,
    Palauan,
    Panamanian,
    Papua_New_Guinean,
    Paraguayan,
    Peruvian,
    Polish,
    Portuguese,
    Qatari,
    Romanian,
    Russian,
    Rwandan,
    Saint_Lucian,
    Salvadoran,
    Samoan,
    San_Marinese,
    Sao_Tomean,
    Saudi,
    Scottish,
    Senegalese,
    Serbian,
    Seychellois,
    Sierra_Leonean,
    Singaporean,
    Slovakian,
    Slovenian,
    Solomon_Islander,
    Somali,
    South_African,
    South_Korean,
    Spanish,
    Sri_Lankan,
    Sudanese,
    Surinamer,
    Swazi,
    Swedish,
    Swiss,
    Syrian,
    Taiwanese,
    Tajik,
    Tanzanian,
    Thai,
    Togolese,
    Tongan,
    Trinidadian_or_Tobagonian,
    Tunisian,
    Turkish,
    Tuvaluan,
    Ugandan,
    Ukrainian,
    Uruguayan,
    Uzbekistani,
    Venezuelan,
    Vietnamese,
    Welsh,
    Yemenite,
    Zambian,
    Zimbabwean
}

public enum Language
{
    Abkhaz,
    Achinese,
    Acoli,
    Adangme,
    Adyghe,
    Afar,
    Afrikaans,
    Ainu,
    Akan,
    Albanian,
    Aleut,
    Algonquian_Languages,
    Altaic_Languages,
    Amharic,
    Ancient_Egyptian,
    Arabic,
    Aragonese,
    Aramaic,
    Armenian,
    Aromanian,
    Assamese,
    Asturian,
    Athapascan_Languages,
    Australian_Languages,
    Austronesian_Languages,
    Avaric,
    Avestan,
    Awadhi,
    Aymara,
    Azerbaijani,
    Balinese,
    Baltic_Languages,
    Baluchi,
    Bambara,
    Bamileke_Languages,
    Banda_Languages,
    Bantu_Languages,
    Basa,
    Bashkir,
    Basque,
    Batak_Languages,
    Beja,
    Belarusian,
    Bemba,
    Bengali,
    Berber_Languages,
    Bhojpuri,
    Bihari_Languages,
    Bikol,
    Bini,
    Bislama,
    Blissymbols,
    Bosnian,
    Braj,
    Breton,
    Buginese,
    Bulgarian,
    Buriat,
    Burmese,
    Caddo,
    Central_American_Indian_Languages,
    Celtic_Languages,
    Central_Khmer,
    Chagatai,
    Chamorro,
    Chechen,
    Cherokee,
    Cheyenne,
    Chibcha,
    Chinese,
    Chinook_jargon,
    Chipewyan,
    Choctaw,
    Chuukese,
    Chuvash,
    Classical_Newari,
    Classical_Syriac,
    Cook_Islands_Maori,
    Coptic,
    Cornish,
    Corsican,
    Cree,
    Creek,
    Crimean_Tatar,
    Croatian,
    Cushitic_Languages,
    Czech,
    Dakota,
    Danish,
    Dargwa,
    Delaware,
    Dinka,
    Divehi,
    Dogri,
    Dravidian_Languages,
    Duala,
    Dutch,
    Dyula,
    Dzongkha,
    Eastern_Frisian,
    Efik,
    Egyptian_Ancient,
    Ekajuk,
    Elamite,
    English,
    Erzya,
    Esperanto,
    Estonian,
    Ewe,
    Ewondo,
    Fang,
    Fanti,
    Faroese,
    Fijian,
    Filipino,
    Finnish,
    Finno_Ugrian_Languages,
    Fon,
    French,
    Friulian,
    Fulah,
    Ga,
    Gaelic,
    Galibi_Carib,
    Galician,
    Ganda,
    Gayo,
    Gbaya,
    Geez,
    Georgian,
    German,
    Germanic_Languages,
    Gilbertese,
    Gondi,
    Gorontalo,
    Gothic,
    Grebo,
    Greek_Ancient,
    Greek_Modern,
    Greenlandic,
    Guarani,
    Gujarati,
    Gwich_in,
    Haida,
    Haitian,
    Hausa,
    Hawaiian,
    Hebrew,
    Herero,
    Hiligaynon,
    Himachali_Languages,
    Hindi,
    Hiri_Motu,
    Hittite,
    Hmong,
    Hungarian,
    Hupa,
    Iban,
    Icelandic,
    Ido,
    Igbo,
    Ijo_Languages,
    Iloko,
    Inari_Sami,
    Indic_Languages,
    Indo_European_Languages,
    Indonesian,
    Ingush,
    Interlingua,
    Interlingue,
    Inuktitut,
    Inupiaq,
    Iranian_Languages,
    Irish,
    Irish_Middle,
    Irish_Old,
    Iroquoian_Languages,
    Italian,
    Japanese,
    Javanese,
    Judeo_Arabic,
    Judeo_Persian,
    Kabardian,
    Kabyle,
    Kachin,
    Kalaallisut,
    Kalmyk_Oirat,
    Kamba,
    Kannada,
    Kanuri,
    Karachay_Balkar,
    Kara_Kalpak,
    Karelian,
    Karen_Languages,
    Kashmiri,
    Kashubian,
    Kawi,
    Kazakh,
    Khasi,
    Khoisan_Languages,
    Khotanese,
    Kikuyu,
    Kimbundu,
    Kinyarwanda,
    Kirghiz,
    Komi,
    Kongo,
    Konkani,
    Korean,
    Kosraean,
    Kpelle,
    Kru_Languages,
    Kuanyama,
    Kumyk,
    Kurdish,
    Kurukh,
    Kutenai,
    Ladino,
    Lahnda,
    Lamba,
    Lao,
    Latin,
    Latvian,
    Lezghian,
    Limburgan,
    Lingala,
    Lithuanian,
    Lojban,
    Lombard,
    Low_German,
    Low_Saxon,
    Lower_Sorbian,
    Lozi,
    Luba_Lulua,
    Luba_Katanga,
    Lule_Sami,
    Lunda,
    Luo,
    Lushai,
    Luxembourgish,
    Macedonian,
    Madurese,
    Magahi,
    Maithili,
    Makasar,
    Malagasy,
    Malay,
    Malayalam,
    Maltese,
    Manchu,
    Mandar,
    Mandingo,
    Manipuri,
    Manobo_Languages,
    Manx,
    Maori,
    Mapudungun,
    Marathi,
    Mari,
    Marshallese,
    Marwari,
    Masai,
    Mayan_Languages,
    Mende,
    Micmac,
    Minangkabau,
    Mirandese,
    Mohawk,
    Moksha,
    Mon_Khmer_Languages,
    Mongo,
    Mongolian,
    Montenegrin,
    Mossi,
    Multiple_Languages,
    Munda_Languages,
    N_A,
    Nahuatl_Languages,
    Nauru,
    Navajo,
    Ndebele_North,
    Ndebele_South,
    Ndonga,
    Neapolitan,
    Nepali,
    Newari,
    Nias,
    Niger_Kordofanian_Languages,
    Niuean,
    Nogai,
    Norse_Old,
    North_American_Indian_Languages,
    Northern_Sami,
    Northern_Sotho,
    Norwegian,
    Norwegian_Bokmal,
    Norwegian_Nynorsk,
    Nubian_Languages,
    Nyamwezi,
    Nyanja,
    Nyankole,
    Nyoro,
    Nzima,
    Occitan,
    Ojibwa,
    Oriya,
    Oromo,
    Osage,
    Ossetian,
    Ottoman_Turkish,
    Otomian_Languages,
    Pahlavi,
    Palauan,
    Pali,
    Pampanga,
    Pangasinan,
    Panjabi,
    Papiamento,
    Papuan_Austral,
    Persian,
    Philippine_Languages,
    Phoenician,
    Pohnpeian,
    Polish,
    Portuguese,
    Prakrit_Languages,
    Provencal_Occitan,
    Pushto,
    Quechua,
    Rajasthani,
    Rapanui,
    Rarotongan,
    Romance_Languages,
    Romanian,
    Romansh,
    Romany,
    Rundi,
    Russian,
    Salishan_Languages,
    Sami_Languages,
    Samoan,
    Sandawe,
    Sango,
    Sanskrit,
    Santali,
    Sardinian,
    Sasak,
    Scots,
    Scottish_Gaelic,
    Selkup,
    Semitic_Languages,
    Serbian,
    Serbo_Croatian,
    Serer,
    Shan,
    Shona,
    Sicilian,
    Sidamo,
    Sign_Languages,
    Siksika,
    Sindhi,
    Sinhala,
    Sino_Tibetan_Languages,
    Siouan_Languages,
    Skolt_Sami,
    Slave_Athapascan_Languages,
    Slavic_Languages,
    Slovak,
    Slovenian,
    Sogdian,
    Somali,
    Songhai_Languages,
    Soninke,
    Sorbian_Languages,
    Sotho_Southern,
    South_American_Indian_Languages,
    Southern_Altai,
    Southern_Sami,
    Spanish,
    Sranan_Tongo,
    Standard_Moroccan_Tamazight,
    Sukuma,
    Sundanese,
    Susu,
    Swahili,
    Swati,
    Swedish,
    Swiss_German,
    Syriac,
    Tagalog,
    Tahitian,
    Tai_Languages,
    Tajik,
    Tamashek,
    Tamil,
    Tatar,
    Telugu,
    Tereno,
    Tetum,
    Thai,
    Tibetan,
    Tigre,
    Tigrinya,
    Timne,
    Tiv,
    Tlingit,
    Tok_Pisin,
    Tokelauan,
    Tonga_Tonga_Islands,
    Tongan,
    Tsimshian,
    Tswana,
    Tumbuka,
    Tupi_Languages,
    Turkish,
    Turkmen,
    Tuvalu,
    Tuvinian,
    Twi,
    Udmurt,
    Ugaritic,
    Uighur,
    Ukrainian,
    Umbundu,
    Undetermined,
    Urdu,
    Uzbek,
    Vai,
    Venda,
    Vietnamese,
    Volapuk,
    Votic,
    Wakashan_Languages,
    Walloon,
    Waray,
    Washo,
    Welsh,
    Western_Frisian,
    Western_Pahari_Languages,
    Wolaitta,
    Wolof,
    Xhosa,
    Yakut,
    Yao,
    Yapese,
    Yiddish,
    Yoruba,
    Yupik_Languages,
    Zapotec,
    Zaza,
    Zenaga,
    Zhuang,
    Zulu,
    Zuni
}
