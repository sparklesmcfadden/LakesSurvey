using LakesSurveyModels;
using LakesSurveyModels.Models;
using Newtonsoft.Json.Linq;

namespace LakesSurvey;

public class FishTypeMachine
{
  private ApplicationDbContext _context;

  public FishTypeMachine(ApplicationDbContext context)
  {
    _context = context;
  }
  
    private static JObject GetFishTypes()
    {
        return JObject.Parse(@"{
  ""LKW"": {
    ""code"": ""LKW"",
    ""common_name"": ""lake whitefish"",
    ""scientific_name"": ""Coregonus clupeaformis"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""RKB"": {
    ""code"": ""RKB"",
    ""common_name"": ""rock bass"",
    ""scientific_name"": ""Ambloplites rupestris"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""LKS"": {
    ""code"": ""LKS"",
    ""common_name"": ""lake sturgeon"",
    ""scientific_name"": ""Acipenser fulvescens"",
    ""game_fish"": true,
    ""species_group"": ""Acipenseridae""
  },
  ""SDS"": {
    ""code"": ""SDS"",
    ""common_name"": ""sand shiner"",
    ""scientific_name"": ""Notropis stramineus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""FLG"": {
    ""code"": ""FLG"",
    ""common_name"": ""Florida gar"",
    ""scientific_name"": ""Lepisosteus platyrhincus"",
    ""game_fish"": false,
    ""species_group"": ""Lepisosteidae""
  },
  ""BLT"": {
    ""code"": ""BLT"",
    ""common_name"": ""bloater"",
    ""scientific_name"": ""Coregonus hoyi"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""BLS"": {
    ""code"": ""BLS"",
    ""common_name"": ""blue sucker"",
    ""scientific_name"": ""Cycleptus elongatus"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""FLC"": {
    ""code"": ""FLC"",
    ""common_name"": ""flathead chub"",
    ""scientific_name"": ""Platygobio gracilis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SDM"": {
    ""code"": ""SDM"",
    ""common_name"": ""slender madtom"",
    ""scientific_name"": ""Noturus exilis"",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""GRC"": {
    ""code"": ""GRC"",
    ""common_name"": ""gravel chub"",
    ""scientific_name"": ""Erimystax x-punctatus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""CRP"": {
    ""code"": ""CRP"",
    ""common_name"": ""crappie"",
    ""scientific_name"": ""Pomoxis sp."",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""SPT"": {
    ""code"": ""SPT"",
    ""common_name"": ""splake"",
    ""scientific_name"": ""Salvelinus fontinalis X S. namaycush"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""SPS"": {
    ""code"": ""SPS"",
    ""common_name"": ""spotted sucker"",
    ""scientific_name"": ""Minytrema melanops"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""BLH"": {
    ""code"": ""BLH"",
    ""common_name"": ""bullheads"",
    ""scientific_name"": ""Ameiurus sp."",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""SPO"": {
    ""code"": ""SPO"",
    ""common_name"": ""spottail shiner"",
    ""scientific_name"": ""Notropis hudsonius"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""BLG"": {
    ""code"": ""BLG"",
    ""common_name"": ""bluegill"",
    ""scientific_name"": ""Lepomis macrochirus"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""LKC"": {
    ""code"": ""LKC"",
    ""common_name"": ""lake chub"",
    ""scientific_name"": ""Couesius plumbeus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""BLD"": {
    ""code"": ""BLD"",
    ""common_name"": ""bluntnose darter"",
    ""scientific_name"": ""Etheostoma chlorosoma"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""BLC"": {
    ""code"": ""BLC"",
    ""common_name"": ""black crappie"",
    ""scientific_name"": ""Pomoxis nigromaculatus"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""RVS"": {
    ""code"": ""RVS"",
    ""common_name"": ""river shiner"",
    ""scientific_name"": ""Notropis blennius"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""BLB"": {
    ""code"": ""BLB"",
    ""common_name"": ""black bullhead"",
    ""scientific_name"": ""Ameiurus melas"",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""CRD"": {
    ""code"": ""CRD"",
    ""common_name"": ""crystal darter"",
    ""scientific_name"": ""Crystallaria asprella"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""CRC"": {
    ""code"": ""CRC"",
    ""common_name"": ""creek chub"",
    ""scientific_name"": ""Semotilus atromaculatus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SPG"": {
    ""code"": ""SPG"",
    ""common_name"": ""spotted gar"",
    ""scientific_name"": ""Lepisosteus oculatus"",
    ""game_fish"": false,
    ""species_group"": ""Lepisosteidae""
  },
  ""ARG"": {
    ""code"": ""ARG"",
    ""common_name"": ""Arctic grayling"",
    ""scientific_name"": ""Thymallus arcticus"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""SPC"": {
    ""code"": ""SPC"",
    ""common_name"": ""speckled chub"",
    ""scientific_name"": ""Macrhybopsis aestivalis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""ARC"": {
    ""code"": ""ARC"",
    ""common_name"": ""Arctic char"",
    ""scientific_name"": ""Salvelinus alpinus"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""SCU"": {
    ""code"": ""SCU"",
    ""common_name"": ""sculpin"",
    ""scientific_name"": ""Cottus sp."",
    ""game_fish"": false,
    ""species_group"": ""Cottidae""
  },
  ""SCT"": {
    ""code"": ""SCT"",
    ""common_name"": ""siscowet"",
    ""scientific_name"": ""Salvelinus namaycush siscowet"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""TIT"": {
    ""code"": ""TIT"",
    ""common_name"": ""tiger trout"",
    ""scientific_name"": ""Salmo trutta X Salvelinus fontinalis"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""BKT"": {
    ""code"": ""BKT"",
    ""common_name"": ""brook trout"",
    ""scientific_name"": ""Salvelinus fontinalis"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""BKS"": {
    ""code"": ""BKS"",
    ""common_name"": ""brook silverside"",
    ""scientific_name"": ""Labidesthes sicculus"",
    ""game_fish"": false,
    ""species_group"": ""Atherinidae""
  },
  ""RVD"": {
    ""code"": ""RVD"",
    ""common_name"": ""river darter"",
    ""scientific_name"": ""Percina shumardi"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""MDD"": {
    ""code"": ""MDD"",
    ""common_name"": ""mud darter"",
    ""scientific_name"": ""Etheostoma asprigene"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""DWS"": {
    ""code"": ""DWS"",
    ""common_name"": ""deepwater sculpin"",
    ""scientific_name"": ""Myoxocephalus thompsonii"",
    ""game_fish"": false,
    ""species_group"": ""Cottidae""
  },
  ""TIL"": {
    ""code"": ""TIL"",
    ""common_name"": ""blue tilapia"",
    ""scientific_name"": ""Oreochromis aureus"",
    ""game_fish"": false,
    ""species_group"": ""Cichlidae""
  },
  ""RIR"": {
    ""code"": ""RIR"",
    ""common_name"": ""river ruffe"",
    ""scientific_name"": ""Gymnocephalus cernuus"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""BKF"": {
    ""code"": ""BKF"",
    ""common_name"": ""banded killifish"",
    ""scientific_name"": ""Fundulus diaphanus"",
    ""game_fish"": false,
    ""species_group"": ""Fundulidae""
  },
  ""PIR"": {
    ""code"": ""PIR"",
    ""common_name"": ""red breasted pirahna"",
    ""scientific_name"": ""Piaractus brachypomus"",
    ""game_fish"": false,
    ""species_group"": ""Characidae""
  },
  ""BKB"": {
    ""code"": ""BKB"",
    ""common_name"": ""black buffalo"",
    ""scientific_name"": ""Ictiobus niger"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""MCP"": {
    ""code"": ""MCP"",
    ""common_name"": ""mirror carp"",
    ""scientific_name"": ""Cyprinus carpio - variation"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""CPS"": {
    ""code"": ""CPS"",
    ""common_name"": ""carpsucker"",
    ""scientific_name"": ""Carpiodes sp."",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""SBL"": {
    ""code"": ""SBL"",
    ""common_name"": ""southern brook lamprey"",
    ""scientific_name"": ""Ichthyomyzon gagei"",
    ""game_fish"": false,
    ""species_group"": ""Petromyzontidae""
  },
  ""QBS"": {
    ""code"": ""QBS"",
    ""common_name"": ""quillback"",
    ""scientific_name"": ""Carpiodes cyprinus"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""RHS"": {
    ""code"": ""RHS"",
    ""common_name"": ""redhorse"",
    ""scientific_name"": ""Moxostoma sp."",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""MOE"": {
    ""code"": ""MOE"",
    ""common_name"": ""mooneye"",
    ""scientific_name"": ""Hiodon tergisus"",
    ""game_fish"": false,
    ""species_group"": ""Hiodontidae""
  },
  ""KOK"": {
    ""code"": ""KOK"",
    ""common_name"": ""kokanee"",
    ""scientific_name"": ""Oncorhynchus nerka"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""WAS"": {
    ""code"": ""WAS"",
    ""common_name"": ""walleye/sauger"",
    ""scientific_name"": ""Sander vitreus X S. canadensis"",
    ""game_fish"": true,
    ""species_group"": ""Percidae""
  },
  ""GOS"": {
    ""code"": ""GOS"",
    ""common_name"": ""golden shiner"",
    ""scientific_name"": ""Notemigonus crysoleucas"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""WAM"": {
    ""code"": ""WAM"",
    ""common_name"": ""warmouth"",
    ""scientific_name"": ""Lepomis gulosus"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""SNG"": {
    ""code"": ""SNG"",
    ""common_name"": ""shortnose gar"",
    ""scientific_name"": ""Lepisosteus platostomus"",
    ""game_fish"": false,
    ""species_group"": ""Lepisosteidae""
  },
  ""NHS"": {
    ""code"": ""NHS"",
    ""common_name"": ""northern hog sucker"",
    ""scientific_name"": ""Hypentelium nigricans"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""SNC"": {
    ""code"": ""SNC"",
    ""common_name"": ""shortnose cisco"",
    ""scientific_name"": ""Coregonus reighardi"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""IOD"": {
    ""code"": ""IOD"",
    ""common_name"": ""Iowa darter"",
    ""scientific_name"": ""Etheostoma exile"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""WAE"": {
    ""code"": ""WAE"",
    ""common_name"": ""walleye"",
    ""scientific_name"": ""Sander vitreus"",
    ""game_fish"": true,
    ""species_group"": ""Percidae""
  },
  ""SAR"": {
    ""code"": ""SAR"",
    ""common_name"": ""sauger"",
    ""scientific_name"": ""Sander canadensis"",
    ""game_fish"": true,
    ""species_group"": ""Percidae""
  },
  ""PTM"": {
    ""code"": ""PTM"",
    ""common_name"": ""plains topminnow"",
    ""scientific_name"": ""Fundulus sciadicus"",
    ""game_fish"": false,
    ""species_group"": ""Fundulidae""
  },
  ""GOF"": {
    ""code"": ""GOF"",
    ""common_name"": ""goldfish"",
    ""scientific_name"": ""Carassius auratus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""COS"": {
    ""code"": ""COS"",
    ""common_name"": ""coho salmon"",
    ""scientific_name"": ""Oncorhynchus kisutch"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""GOE"": {
    ""code"": ""GOE"",
    ""common_name"": ""goldeye"",
    ""scientific_name"": ""Hiodon alosoides"",
    ""game_fish"": false,
    ""species_group"": ""Hiodontidae""
  },
  ""CCF"": {
    ""code"": ""CCF"",
    ""common_name"": ""channel catfish"",
    ""scientific_name"": ""Ictalurus punctatus"",
    ""game_fish"": true,
    ""species_group"": ""Ictaluridae""
  },
  ""SMT"": {
    ""code"": ""SMT"",
    ""common_name"": ""speckled madtom"",
    ""scientific_name"": ""Noturus leptacanthus"",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""SMS"": {
    ""code"": ""SMS"",
    ""common_name"": ""slimy sculpin"",
    ""scientific_name"": ""Cottus cognatus"",
    ""game_fish"": false,
    ""species_group"": ""Cottidae""
  },
  ""OZM"": {
    ""code"": ""OZM"",
    ""common_name"": ""Ozark minnow"",
    ""scientific_name"": ""Notropis nubilus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""TST"": {
    ""code"": ""TST"",
    ""common_name"": ""threespine stickleback"",
    ""scientific_name"": ""Gasterosteus aculeatus"",
    ""game_fish"": false,
    ""species_group"": ""Gasterosteidae""
  },
  ""PGW"": {
    ""code"": ""PGW"",
    ""common_name"": ""pygmy whitefish"",
    ""scientific_name"": ""Prosopium coulterii"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""PGS"": {
    ""code"": ""PGS"",
    ""common_name"": ""pugnose shiner"",
    ""scientific_name"": ""Notropis anogenus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SAB"": {
    ""code"": ""SAB"",
    ""common_name"": ""smallmouth buffalo"",
    ""scientific_name"": ""Ictiobus bubalus"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""BIB"": {
    ""code"": ""BIB"",
    ""common_name"": ""bigmouth buffalo"",
    ""scientific_name"": ""Ictiobus cyprinellus"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""PGM"": {
    ""code"": ""PGM"",
    ""common_name"": ""pugnose minnow"",
    ""scientific_name"": ""Opsopoeodus emiliae"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""FHM"": {
    ""code"": ""FHM"",
    ""common_name"": ""fathead minnow"",
    ""scientific_name"": ""Pimephales promelas"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""RGB"": {
    ""code"": ""RGB"",
    ""common_name"": ""round goby"",
    ""scientific_name"": ""Neogobius melanostomus"",
    ""game_fish"": false,
    ""species_group"": ""Gobiidae""
  },
  ""SMB"": {
    ""code"": ""SMB"",
    ""common_name"": ""smallmouth bass"",
    ""scientific_name"": ""Micropterus dolomieu"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""HHC"": {
    ""code"": ""HHC"",
    ""common_name"": ""hornyhead chub"",
    ""scientific_name"": ""Nocomis biguttatus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""BUB"": {
    ""code"": ""BUB"",
    ""common_name"": ""burbot"",
    ""scientific_name"": ""Lota lota"",
    ""game_fish"": false,
    ""species_group"": ""Gadidae""
  },
  ""MMS"": {
    ""code"": ""MMS"",
    ""common_name"": ""mimic shiner"",
    ""scientific_name"": ""Notropis volucellus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""LGP"": {
    ""code"": ""LGP"",
    ""common_name"": ""logperch"",
    ""scientific_name"": ""Percina caprodes"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""NST"": {
    ""code"": ""NST"",
    ""common_name"": ""ninespine stickleback"",
    ""scientific_name"": ""Pungitius pungitius"",
    ""game_fish"": false,
    ""species_group"": ""Gasterosteidae""
  },
  ""RSD"": {
    ""code"": ""RSD"",
    ""common_name"": ""redside dace"",
    ""scientific_name"": ""Clinostomus elongatus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""YLB"": {
    ""code"": ""YLB"",
    ""common_name"": ""yellow bass"",
    ""scientific_name"": ""Morone mississippiensis"",
    ""game_fish"": true,
    ""species_group"": ""Moronidae""
  },
  ""ABL"": {
    ""code"": ""ABL"",
    ""common_name"": ""American brook lamprey"",
    ""scientific_name"": ""Lethenteron appendix"",
    ""game_fish"": false,
    ""species_group"": ""Petromyzontidae""
  },
  ""BHM"": {
    ""code"": ""BHM"",
    ""common_name"": ""bullhead minnow"",
    ""scientific_name"": ""Pimephales vigilax"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""RFS"": {
    ""code"": ""RFS"",
    ""common_name"": ""rosyface shiner"",
    ""scientific_name"": ""Notropis rubellus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SLS"": {
    ""code"": ""SLS"",
    ""common_name"": ""shovelnose sturgeon"",
    ""scientific_name"": ""Scaphirhynchus platorynchus"",
    ""game_fish"": true,
    ""species_group"": ""Acipenseridae""
  },
  ""CNM"": {
    ""code"": ""CNM"",
    ""common_name"": ""central mudminnow"",
    ""scientific_name"": ""Umbra limi"",
    ""game_fish"": false,
    ""species_group"": ""Umbridae""
  },
  ""LSR"": {
    ""code"": ""LSR"",
    ""common_name"": ""largescale stoneroller"",
    ""scientific_name"": ""Campostoma oligolepis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SLR"": {
    ""code"": ""SLR"",
    ""common_name"": ""silver redhorse"",
    ""scientific_name"": ""Moxostoma anisurum"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""GAP"": {
    ""code"": ""GAP"",
    ""common_name"": ""grass carp"",
    ""scientific_name"": ""Ctenopharyngodon idella"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""FTD"": {
    ""code"": ""FTD"",
    ""common_name"": ""fantail darter"",
    ""scientific_name"": ""Etheostoma flabellare"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""TRP"": {
    ""code"": ""TRP"",
    ""common_name"": ""trout-perch"",
    ""scientific_name"": ""Percopsis omiscomaycus"",
    ""game_fish"": true,
    ""species_group"": ""Percopsidae""
  },
  ""SLM"": {
    ""code"": ""SLM"",
    ""common_name"": ""Mississippi silvery minnow"",
    ""scientific_name"": ""Hybognathus nuchalis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""BHC"": {
    ""code"": ""BHC"",
    ""common_name"": ""bighead carp"",
    ""scientific_name"": ""Hypophthalmichthys nobilis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SLC"": {
    ""code"": ""SLC"",
    ""common_name"": ""silver chub"",
    ""scientific_name"": ""Macrhybopsis storeriana"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""CAP"": {
    ""code"": ""CAP"",
    ""common_name"": ""common carp"",
    ""scientific_name"": ""Cyprinus carpio"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""EMS"": {
    ""code"": ""EMS"",
    ""common_name"": ""emerald shiner"",
    ""scientific_name"": ""Notropis atherinoides"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""FST"": {
    ""code"": ""FST"",
    ""common_name"": ""fourspine stickleback"",
    ""scientific_name"": ""Apeltes quadracus"",
    ""game_fish"": false,
    ""species_group"": ""Gasterosteidae""
  },
  ""PRP"": {
    ""code"": ""PRP"",
    ""common_name"": ""pirate perch"",
    ""scientific_name"": ""Aphredoderus sayanus"",
    ""game_fish"": false,
    ""species_group"": ""Aphredoderidae""
  },
  ""RRH"": {
    ""code"": ""RRH"",
    ""common_name"": ""river redhorse"",
    ""scientific_name"": ""Moxostoma carinatum"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""CMS"": {
    ""code"": ""CMS"",
    ""common_name"": ""carmine shiner"",
    ""scientific_name"": ""Notropis percobromus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""HSF"": {
    ""code"": ""HSF"",
    ""common_name"": ""hybrid sunfish"",
    ""scientific_name"": ""Lepomis sp. X Lepomis sp."",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""RES"": {
    ""code"": ""RES"",
    ""common_name"": ""redfin shiner"",
    ""scientific_name"": ""Lythrurus umbratilis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""PRD"": {
    ""code"": ""PRD"",
    ""common_name"": ""northern pearl dace"",
    ""scientific_name"": ""Margariscus nachtriebi"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""HFS"": {
    ""code"": ""HFS"",
    ""common_name"": ""highfin carpsucker"",
    ""scientific_name"": ""Carpiodes velifer"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""BST"": {
    ""code"": ""BST"",
    ""common_name"": ""brook stickleback"",
    ""scientific_name"": ""Culaea inconstans"",
    ""game_fish"": false,
    ""species_group"": ""Gasterosteidae""
  },
  ""BSS"": {
    ""code"": ""BSS"",
    ""common_name"": ""bluespotted sunfish"",
    ""scientific_name"": ""Enneacanthus gloriosus"",
    ""game_fish"": false,
    ""species_group"": ""Centrarchidae""
  },
  ""SKM"": {
    ""code"": ""SKM"",
    ""common_name"": ""suckermouth minnow"",
    ""scientific_name"": ""Phenacobius mirabilis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""NRD"": {
    ""code"": ""NRD"",
    ""common_name"": ""northern redbelly dace"",
    ""scientific_name"": ""Phoxinus eos"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SKJ"": {
    ""code"": ""SKJ"",
    ""common_name"": ""skipjack herring"",
    ""scientific_name"": ""Alosa chrysochloris"",
    ""game_fish"": false,
    ""species_group"": ""Clupeidae""
  },
  ""DSF"": {
    ""code"": ""DSF"",
    ""common_name"": ""dollar sunfish"",
    ""scientific_name"": ""Lepomis marginatus"",
    ""game_fish"": false,
    ""species_group"": ""Centrarchidae""
  },
  ""GLR"": {
    ""code"": ""GLR"",
    ""common_name"": ""golden redhorse"",
    ""scientific_name"": ""Moxostoma erythrurum"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""AME"": {
    ""code"": ""AME"",
    ""common_name"": ""American eel"",
    ""scientific_name"": ""Anguilla rostrata"",
    ""game_fish"": false,
    ""species_group"": ""Anguillidae""
  },
  ""BSF"": {
    ""code"": ""BSF"",
    ""common_name"": ""banded sunfish"",
    ""scientific_name"": ""Enneacanthus obesus"",
    ""game_fish"": false,
    ""species_group"": ""Centrarchidae""
  },
  ""BSD"": {
    ""code"": ""BSD"",
    ""common_name"": ""blackside darter"",
    ""scientific_name"": ""Percina maculata"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""UK9"": {
    ""code"": ""UK9"",
    ""common_name"": ""unknown fish nine"",
    ""scientific_name"": ""Incompertus nevem"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""LES"": {
    ""code"": ""LES"",
    ""common_name"": ""northern sunfish"",
    ""scientific_name"": ""Lepomis peltastes"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""UK8"": {
    ""code"": ""UK8"",
    ""common_name"": ""unknown fish eight"",
    ""scientific_name"": ""Incompertus duodeviginti"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""UK7"": {
    ""code"": ""UK7"",
    ""common_name"": ""unknown fish seven"",
    ""scientific_name"": ""Incompertus septem"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""UK6"": {
    ""code"": ""UK6"",
    ""common_name"": ""unknown fish six"",
    ""scientific_name"": ""Incompertus six"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""ILA"": {
    ""code"": ""ILA"",
    ""common_name"": ""lamprey ammocoete"",
    ""scientific_name"": ""Lamprey Ammocoete"",
    ""game_fish"": false,
    ""species_group"": ""Petromyzontidae""
  },
  ""UK5"": {
    ""code"": ""UK5"",
    ""common_name"": ""unknown fish five"",
    ""scientific_name"": ""Incompertus quinque"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""UK4"": {
    ""code"": ""UK4"",
    ""common_name"": ""unknown fish four"",
    ""scientific_name"": ""Incompertus quattuor"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""UK3"": {
    ""code"": ""UK3"",
    ""common_name"": ""unknown fish three"",
    ""scientific_name"": ""Incompertus three"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""RDW"": {
    ""code"": ""RDW"",
    ""common_name"": ""round whitefish"",
    ""scientific_name"": ""Prosopium cylindraceum"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""UK2"": {
    ""code"": ""UK2"",
    ""common_name"": ""unknown fish two"",
    ""scientific_name"": ""Incompertus duos"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""GLD"": {
    ""code"": ""GLD"",
    ""common_name"": ""gilt darter"",
    ""scientific_name"": ""Percina evides"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""UK1"": {
    ""code"": ""UK1"",
    ""common_name"": ""unknown fish one"",
    ""scientific_name"": ""Incompertus unus"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""ALW"": {
    ""code"": ""ALW"",
    ""common_name"": ""alewife"",
    ""scientific_name"": ""Alosa pseudoharengus"",
    ""game_fish"": false,
    ""species_group"": ""Clupeidae""
  },
  ""RDS"": {
    ""code"": ""RDS"",
    ""common_name"": ""red shiner"",
    ""scientific_name"": ""Cyprinella lutrensis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""LED"": {
    ""code"": ""LED"",
    ""common_name"": ""least darter"",
    ""scientific_name"": ""Etheostoma microperca"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""FRD"": {
    ""code"": ""FRD"",
    ""common_name"": ""freshwater drum"",
    ""scientific_name"": ""Aplodinotus grunniens"",
    ""game_fish"": false,
    ""species_group"": ""Sciaenidae""
  },
  ""TPM"": {
    ""code"": ""TPM"",
    ""common_name"": ""tadpole madtom"",
    ""scientific_name"": ""Noturus gyrinus"",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""BFC"": {
    ""code"": ""BFC"",
    ""common_name"": ""blackfin cisco"",
    ""scientific_name"": ""Coregonus nigripinnis"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""BRM"": {
    ""code"": ""BRM"",
    ""common_name"": ""brassy minnow"",
    ""scientific_name"": ""Hybognathus hankinsoni"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""ALG"": {
    ""code"": ""ALG"",
    ""common_name"": ""alligator gar"",
    ""scientific_name"": ""Atractosteus spatula"",
    ""game_fish"": false,
    ""species_group"": ""Lepisosteidae""
  },
  ""BRH"": {
    ""code"": ""BRH"",
    ""common_name"": ""black redhorse"",
    ""scientific_name"": ""Moxostoma duquesnei"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""SJC"": {
    ""code"": ""SJC"",
    ""common_name"": ""shortjaw cisco"",
    ""scientific_name"": ""Coregonus zenithicus"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""BRB"": {
    ""code"": ""BRB"",
    ""common_name"": ""brown bullhead"",
    ""scientific_name"": ""Ameiurus nebulosus"",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""NPS"": {
    ""code"": ""NPS"",
    ""common_name"": "" No particular species"",
    ""scientific_name"": ""Haud proprius proprius"",
    ""game_fish"": false,
    ""species_group"": ""Unknown sp.""
  },
  ""RCS"": {
    ""code"": ""RCS"",
    ""common_name"": ""river carpsucker"",
    ""scientific_name"": ""Carpiodes carpio"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""SIP"": {
    ""code"": ""SIP"",
    ""common_name"": ""northern pike (silver phase)"",
    ""scientific_name"": ""Esox lucius - variation"",
    ""game_fish"": true,
    ""species_group"": ""Esocidae""
  },
  ""SIL"": {
    ""code"": ""SIL"",
    ""common_name"": ""silver lamprey"",
    ""scientific_name"": ""Ichthyomyzon unicuspis"",
    ""game_fish"": false,
    ""species_group"": ""Petromyzontidae""
  },
  ""NPC"": {
    ""code"": ""NPC"",
    ""common_name"": ""Nipigon cisco"",
    ""scientific_name"": ""Coregonus nipigon"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""SUN"": {
    ""code"": ""SUN"",
    ""common_name"": ""sunfish"",
    ""scientific_name"": ""Lepomis sp."",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""SIC"": {
    ""code"": ""SIC"",
    ""common_name"": ""silver carp"",
    ""scientific_name"": ""Hypophthalmichthys molitrix"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""WHP"": {
    ""code"": ""WHP"",
    ""common_name"": ""white perch"",
    ""scientific_name"": ""Morone americana"",
    ""game_fish"": true,
    ""species_group"": ""Moronidae""
  },
  ""LCP"": {
    ""code"": ""LCP"",
    ""common_name"": ""leather carp"",
    ""scientific_name"": ""Cyprinus carpio - variation"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""BDS"": {
    ""code"": ""BDS"",
    ""common_name"": ""banded sculpin"",
    ""scientific_name"": ""Cottus carolinea"",
    ""game_fish"": false,
    ""species_group"": ""Cottidae""
  },
  ""NOP"": {
    ""code"": ""NOP"",
    ""common_name"": ""northern pike"",
    ""scientific_name"": ""Esox lucius"",
    ""game_fish"": true,
    ""species_group"": ""Esocidae""
  },
  ""WTS"": {
    ""code"": ""WTS"",
    ""common_name"": ""white sucker"",
    ""scientific_name"": ""Catostomus commersonii"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""RBT"": {
    ""code"": ""RBT"",
    ""common_name"": ""rainbow trout"",
    ""scientific_name"": ""Oncorhynchus mykiss"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""RBS"": {
    ""code"": ""RBS"",
    ""common_name"": ""rainbow smelt"",
    ""scientific_name"": ""Osmerus mordax"",
    ""game_fish"": false,
    ""species_group"": ""Osmeridae""
  },
  ""SHS"": {
    ""code"": ""SHS"",
    ""common_name"": ""spoonhead sculpin"",
    ""scientific_name"": ""Cottus ricei"",
    ""game_fish"": false,
    ""species_group"": ""Cottidae""
  },
  ""SHR"": {
    ""code"": ""SHR"",
    ""common_name"": ""shorthead redhorse"",
    ""scientific_name"": ""Moxostoma macrolepidotum"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""WHC"": {
    ""code"": ""WHC"",
    ""common_name"": ""white crappie"",
    ""scientific_name"": ""Pomoxis annularis"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""WHB"": {
    ""code"": ""WHB"",
    ""common_name"": ""white bass"",
    ""scientific_name"": ""Morone chrysops"",
    ""game_fish"": true,
    ""species_group"": ""Moronidae""
  },
  ""HCR"": {
    ""code"": ""HCR"",
    ""common_name"": ""hybrid crappie"",
    ""scientific_name"": ""Pomoxis sp. X Pomoxis sp."",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""BDD"": {
    ""code"": ""BDD"",
    ""common_name"": ""banded darter"",
    ""scientific_name"": ""Etheostoma zonale"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""SHI"": {
    ""code"": ""SHI"",
    ""common_name"": ""shiners"",
    ""scientific_name"": ""Notropis etc."",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""GIS"": {
    ""code"": ""GIS"",
    ""common_name"": ""gizzard shad"",
    ""scientific_name"": ""Dorosoma cepedianum"",
    ""game_fish"": false,
    ""species_group"": ""Clupeidae""
  },
  ""KIC"": {
    ""code"": ""KIC"",
    ""common_name"": ""kiyi"",
    ""scientific_name"": ""Coregonus kiyi"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""RBD"": {
    ""code"": ""RBD"",
    ""common_name"": ""rainbow darter"",
    ""scientific_name"": ""Etheostoma caeruleum"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""TNG"": {
    ""code"": ""TNG"",
    ""common_name"": ""tubenose goby"",
    ""scientific_name"": ""Proterorhinus marmoratus"",
    ""game_fish"": false,
    ""species_group"": ""Gobiidae""
  },
  ""SHD"": {
    ""code"": ""SHD"",
    ""common_name"": ""slenderhead darter"",
    ""scientific_name"": ""Percina phoxocephala"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""MUE"": {
    ""code"": ""MUE"",
    ""common_name"": ""muskellunge"",
    ""scientific_name"": ""Esox masquinongy"",
    ""game_fish"": true,
    ""species_group"": ""Esocidae""
  },
  ""SHC"": {
    ""code"": ""SHC"",
    ""common_name"": ""shoal chub"",
    ""scientific_name"": ""Macrhybopsis hyostoma"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""STM"": {
    ""code"": ""STM"",
    ""common_name"": ""starhead topminnow"",
    ""scientific_name"": ""Fundulus dispar"",
    ""game_fish"": false,
    ""species_group"": ""Fundulidae""
  },
  ""NBL"": {
    ""code"": ""NBL"",
    ""common_name"": ""northern brook lamprey"",
    ""scientific_name"": ""Ichthyomyzon fossor"",
    ""game_fish"": false,
    ""species_group"": ""Petromyzontidae""
  },
  ""FCF"": {
    ""code"": ""FCF"",
    ""common_name"": ""flathead catfish"",
    ""scientific_name"": ""Pylodictis olivaris"",
    ""game_fish"": true,
    ""species_group"": ""Ictaluridae""
  },
  ""BCS"": {
    ""code"": ""BCS"",
    ""common_name"": ""blackchin shiner"",
    ""scientific_name"": ""Notropis heterodon"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""CIS"": {
    ""code"": ""CIS"",
    ""common_name"": ""cisco species"",
    ""scientific_name"": ""Leucichthys sp."",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""OTS"": {
    ""code"": ""OTS"",
    ""common_name"": ""suckers"",
    ""scientific_name"": ""Catostomus sp."",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""STC"": {
    ""code"": ""STC"",
    ""common_name"": ""stonecat"",
    ""scientific_name"": ""Noturus flavus"",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""STB"": {
    ""code"": ""STB"",
    ""common_name"": ""striped bass"",
    ""scientific_name"": ""Morone saxatilis"",
    ""game_fish"": false,
    ""species_group"": ""Moronidae""
  },
  ""LNS"": {
    ""code"": ""LNS"",
    ""common_name"": ""longnose sucker"",
    ""scientific_name"": ""Catostomus catostomus"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  },
  ""OTM"": {
    ""code"": ""OTM"",
    ""common_name"": ""minnows"",
    ""scientific_name"": ""Small Cyprinids"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""MTS"": {
    ""code"": ""MTS"",
    ""common_name"": ""mottled sculpin"",
    ""scientific_name"": ""Cottus bairdii"",
    ""game_fish"": false,
    ""species_group"": ""Cottidae""
  },
  ""BCF"": {
    ""code"": ""BCF"",
    ""common_name"": ""blue catfish"",
    ""scientific_name"": ""Ictalurus furcatus"",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""GHS"": {
    ""code"": ""GHS"",
    ""common_name"": ""ghost shiner"",
    ""scientific_name"": ""Notropis buchanani"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""LNG"": {
    ""code"": ""LNG"",
    ""common_name"": ""longnose gar"",
    ""scientific_name"": ""Lepisosteus osseus"",
    ""game_fish"": false,
    ""species_group"": ""Lepisosteidae""
  },
  ""WSD"": {
    ""code"": ""WSD"",
    ""common_name"": ""western sand darter"",
    ""scientific_name"": ""Ammocrypta clara"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""LND"": {
    ""code"": ""LND"",
    ""common_name"": ""longnose dace"",
    ""scientific_name"": ""Rhinichthys cataractae"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""TME"": {
    ""code"": ""TME"",
    ""common_name"": ""tiger muskellunge"",
    ""scientific_name"": ""Esox lucius X E. masquinongy"",
    ""game_fish"": true,
    ""species_group"": ""Esocidae""
  },
  ""BOF"": {
    ""code"": ""BOF"",
    ""common_name"": ""bowfin (dogfish)"",
    ""scientific_name"": ""Amia calva"",
    ""game_fish"": false,
    ""species_group"": ""Amiidae""
  },
  ""PAH"": {
    ""code"": ""PAH"",
    ""common_name"": ""paddlefish"",
    ""scientific_name"": ""Polyodon spathula"",
    ""game_fish"": true,
    ""species_group"": ""Polyodontidae""
  },
  ""LAT"": {
    ""code"": ""LAT"",
    ""common_name"": ""lake trout"",
    ""scientific_name"": ""Salvelinus namaycush namaycush"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""JND"": {
    ""code"": ""JND"",
    ""common_name"": ""Johnny darter"",
    ""scientific_name"": ""Etheostoma nigrum"",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""PMK"": {
    ""code"": ""PMK"",
    ""common_name"": ""pumpkinseed"",
    ""scientific_name"": ""Lepomis gibbosus"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""CHS"": {
    ""code"": ""CHS"",
    ""common_name"": ""Chinook salmon"",
    ""scientific_name"": ""Oncorhynchus tshawytscha"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""OSS"": {
    ""code"": ""OSS"",
    ""common_name"": ""orangespotted sunfish"",
    ""scientific_name"": ""Lepomis humilis"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""SFS"": {
    ""code"": ""SFS"",
    ""common_name"": ""spotfin shiner"",
    ""scientific_name"": ""Cyprinella spiloptera"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""CHL"": {
    ""code"": ""CHL"",
    ""common_name"": ""chestnut lamprey"",
    ""scientific_name"": ""Ichthyomyzon castaneus"",
    ""game_fish"": false,
    ""species_group"": ""Petromyzontidae""
  },
  ""BNT"": {
    ""code"": ""BNT"",
    ""common_name"": ""brown trout"",
    ""scientific_name"": ""Salmo trutta"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""BNS"": {
    ""code"": ""BNS"",
    ""common_name"": ""blacknose shiner"",
    ""scientific_name"": ""Notropis heterolepis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""FND"": {
    ""code"": ""FND"",
    ""common_name"": ""finescale dace"",
    ""scientific_name"": ""Phoxinus neogaeus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""BNM"": {
    ""code"": ""BNM"",
    ""common_name"": ""bluntnose minnow"",
    ""scientific_name"": ""Pimephales notatus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""ATS"": {
    ""code"": ""ATS"",
    ""common_name"": ""Atlantic salmon"",
    ""scientific_name"": ""Salmo salar"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""YEP"": {
    ""code"": ""YEP"",
    ""common_name"": ""yellow perch"",
    ""scientific_name"": ""Perca flavescens"",
    ""game_fish"": true,
    ""species_group"": ""Percidae""
  },
  ""LMB"": {
    ""code"": ""LMB"",
    ""common_name"": ""largemouth bass"",
    ""scientific_name"": ""Micropterus salmoides"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""PLS"": {
    ""code"": ""PLS"",
    ""common_name"": ""pallid shiner"",
    ""scientific_name"": ""Hybopsis amnis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""DAR"": {
    ""code"": ""DAR"",
    ""common_name"": ""darters"",
    ""scientific_name"": ""Etheostoma etc."",
    ""game_fish"": false,
    ""species_group"": ""Percidae""
  },
  ""TLC"": {
    ""code"": ""TLC"",
    ""common_name"": ""tullibee (cisco)"",
    ""scientific_name"": ""Coregonus artedi"",
    ""game_fish"": false,
    ""species_group"": ""Salmonidae""
  },
  ""BND"": {
    ""code"": ""BND"",
    ""common_name"": ""western blacknose dace"",
    ""scientific_name"": ""Rhinichthys obtusus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SRD"": {
    ""code"": ""SRD"",
    ""common_name"": ""southern redbelly dace"",
    ""scientific_name"": ""Phoxinus erythrogaster"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""YEB"": {
    ""code"": ""YEB"",
    ""common_name"": ""yellow bullhead"",
    ""scientific_name"": ""Ameiurus natalis"",
    ""game_fish"": false,
    ""species_group"": ""Ictaluridae""
  },
  ""TKS"": {
    ""code"": ""TKS"",
    ""common_name"": ""Topeka shiner"",
    ""scientific_name"": ""Notropis topeka"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""BMS"": {
    ""code"": ""BMS"",
    ""common_name"": ""bigmouth shiner"",
    ""scientific_name"": ""Notropis dorsalis"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""GSF"": {
    ""code"": ""GSF"",
    ""common_name"": ""green sunfish"",
    ""scientific_name"": ""Lepomis cyanellus"",
    ""game_fish"": true,
    ""species_group"": ""Centrarchidae""
  },
  ""CSR"": {
    ""code"": ""CSR"",
    ""common_name"": ""central stoneroller"",
    ""scientific_name"": ""Campostoma anomalum"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""SEL"": {
    ""code"": ""SEL"",
    ""common_name"": ""sea lamprey"",
    ""scientific_name"": ""Petromyzon marinus"",
    ""game_fish"": false,
    ""species_group"": ""Petromyzontidae""
  },
  ""ASV"": {
    ""code"": ""ASV"",
    ""common_name"": ""Atlantic silverside"",
    ""scientific_name"": ""Menidia menidia"",
    ""game_fish"": false,
    ""species_group"": ""Atherinidae""
  },
  ""PKS"": {
    ""code"": ""PKS"",
    ""common_name"": ""pink salmon"",
    ""scientific_name"": ""Oncorhynchus gorbuscha"",
    ""game_fish"": true,
    ""species_group"": ""Salmonidae""
  },
  ""CSH"": {
    ""code"": ""CSH"",
    ""common_name"": ""common shiner"",
    ""scientific_name"": ""Luxilus cornutus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""WDS"": {
    ""code"": ""WDS"",
    ""common_name"": ""weed shiner"",
    ""scientific_name"": ""Notropis texanus"",
    ""game_fish"": false,
    ""species_group"": ""Cyprinidae""
  },
  ""GRR"": {
    ""code"": ""GRR"",
    ""common_name"": ""greater redhorse"",
    ""scientific_name"": ""Moxostoma valenciennesi"",
    ""game_fish"": false,
    ""species_group"": ""Catostomidae""
  }
}");
    }

    public async Task LoadFishTypes()
    {
      var fishTypes = GetFishTypes();

      foreach (var keyValuePair in fishTypes)
      {
        var speciesShortName = keyValuePair.Key;
        var speciesLongName = (string)keyValuePair.Value["common_name"];

        var formattedLongName = string.Join(' ', speciesLongName.Trim().ToLower().Split(" ").ToList()
          .Select(s => s[0].ToString().ToUpper() + s[1..]));

        var fishType = new FishType
        {
          FishShortName = speciesShortName,
          FishLongName = (string)formattedLongName
        };

        _context.FishTypes.Add(fishType);
        await _context.SaveChangesAsync();
      }
    }
}


// "RKB": {
//   "code": "RKB",
//   "common_name": "rock bass",
//   "scientific_name": "Ambloplites rupestris",
//   "game_fish": true,
//   "species_group": "Centrarchidae"
// },
// "LKS": {
//   "code": "LKS",
//   "common_name": "lake sturgeon",
//   "scientific_name": "Acipenser fulvescens",
//   "game_fish": true,
//   "species_group": "Acipenseridae"
// },