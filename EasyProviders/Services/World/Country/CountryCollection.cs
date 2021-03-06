﻿using EasyProviders.Services.World.Region;
using System.Collections.Generic;

//DATA : http://www.projectvisa.com/fullcountrylist.asp
//DATA : https://www.state.gov/s/inr/rls/4250.htm
//DATA : http://www.internetworldstats.com/list1.htm

namespace EasyProviders.Services.World.Country {
    public static class CountryCollection {
        public static readonly List<Country> ListOfCountries = new List<Country> {
            new Country("Afghanistan", "AF", "AFG", "Islamic Republic of Afghanistan", "Kabul", RegionType.Asia),
            //new Country("Aland Islands", "N", "N", "NULL", "NULL", RegionType.Asia),
            new Country("Albania", "AL", "ALB", "Republic of Albania", "Tirana", RegionType.Europe),
            new Country("Algeria", "DZ", "DZA", "People's Democratic Republic of Algeria", "Algiers", RegionType.Africa),
            //new Country("American Samoa", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Andorra", "AD", "AND", "Principality of Andorra", "Andorra la Vella", RegionType.Europe),
            new Country("Angola", "AO", "AGO", "Republic of Angola", "Luanda", RegionType.Africa),
            //new Country("Anguilla", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            //new Country("Antarctica", "N", "N", "NULL", "NULL", RegionType.Asia),
            new Country("Antigua & Barbuda", "AG", "ATG", "Antigua and Barbuda", "Saint John's", RegionType.TheCaribbean),
            new Country("Argentina", "AR", "ARG", "Argentine Republic", "Buenos Aires", RegionType.SouthAmerica),
            new Country("Armenia", "AM", "ARM", "Republic of Armenia", "Yerevan", RegionType.Europe),
            //new Country("Aruba", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            //new Country("Ascension Island", "N", "N", "NULL", "NULL", RegionType.Asia),
            new Country("Australia", "AU", "AUS", "Commonwealth of Australia", "Canberra", RegionType.Australasia),
            new Country("Austria", "AT", "AUT", "Republic of Austria", "Vienna", RegionType.Europe),
            new Country("Azerbaijan", "AZ", "AZE", "Republic of Azerbaijan", "Baku", RegionType.Europe),
            new Country("Bahamas", "BS", "BHS", "Commonwealthof The Bahamas", "Nassau", RegionType.TheCaribbean),
            new Country("Bahrain", "BH", "BHR", "Kingdom of Bahrain", "Manama", RegionType.MiddleEast),
            new Country("Bangladesh", "BD", "BGD", "People's Republicof Bangladesh", "Dhaka", RegionType.Asia),
            new Country("Barbados", "BB", "BRB", "Barbados", "Bridgetown", RegionType.TheCaribbean),
            new Country("Belarus", "BY", "BLR", "Republic of Belarus", "Minsk", RegionType.Europe),
            new Country("Belgium", "BE", "BEL", "Kingdom of Belgium", "Brussels", RegionType.Europe),
            new Country("Belize", "BZ", "BLZ", "Belize", "Belmopan", RegionType.NorthAmerica),
            new Country("Benin", "BJ", "BEN", "Republic of Benin", "Porto-Novo", RegionType.Africa),
            //new Country("Bermuda", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            new Country("Bhutan", "BT", "BTN", "Kingdom of Bhutan", "Thimphu", RegionType.Asia),
            new Country("Bolivia", "BO", "BOL", "Plurinational State of Bolivia", "La Paz", RegionType.SouthAmerica),
            //new Country("Bonaire", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            new Country("Bosnia & Herzegovina", "BA", "BIH", "Bosnia & Herzegovina", "Sarajevo", RegionType.Europe),
            new Country("Botswana", "BW", "BWA", "Republic of Botswana", "Gaborone", RegionType.Africa),
            //new Country("Bouvet Island", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Africa),
            new Country("Brazil", "BR", "BRA", "Federative Republic of Brazil", "Brasília", RegionType.SouthAmerica),
            //new Country("British Indian Ocean Territory", "N", "N", "NULL", "NULL", RegionType.Asia),
            //new Country("British Virgin Islands", "N", "N", "NULL", "NULL", RegionType.Asia),
            new Country("Brunei", "BN", "BRN", "Brunei Darussalam", "Bandar Seri Begawan", RegionType.Asia),
            new Country("Bulgaria", "BG", "BGR", "Republic of Bulgaria", "Sofia", RegionType.Europe),
            new Country("Burkina Faso", "BF", "BFA", "Burkina Faso", "Ouagadougou", RegionType.Africa),
            //new Country("Burma", "MM", "MMR", "Union of Burma", "RangoonNay Pyi Taw ", RegionType.Africa),
            new Country("Burundi", "BI", "BDI", "Republic of Burundi", "Bujumbura", RegionType.Africa),
            //new Country("Cabo Verde", "CV", "CPV", "Republic of Cabo Verde", "Praia", RegionType.Asia),
            new Country("Cambodia", "KH", "KHM", "Kingdom of Cambodia", "Phnom Penh", RegionType.Asia),
            new Country("Cameroon", "CM", "CMR", "Republic of Cameroon", "Yaoundé", RegionType.Africa),
            new Country("Canada", "CA", "CAN", "Canada", "Ottawa", RegionType.NorthAmerica),
            //new Country("Canary Islands", "N", "N", "NULL", "NULL", RegionType.Asia),
            //new Country("Cape Verde", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Africa),
            //new Country("Caribbean Netherlands", "N", "N", "NULL", "NULL", RegionType.Asia),
            //new Country("Cayman Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            new Country("Central African Republic", "CF", "CAF", "Central African Republic", "Bangui", RegionType.Africa),
            //new Country("Ceuta & Melilla", "N", "N", "NULL", "NULL", RegionType.Asia),
            new Country("Chad", "TD", "TCD", "Republic of Chad", "N'Djamena", RegionType.Africa),
            new Country("Chile", "CL", "CHL", "Republic of Chile", "Santiago", RegionType.SouthAmerica),
            new Country("China", "CN", "CHN", "People's Republic of China", "Beijing", RegionType.Asia),
            //new Country("Christmas Island", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            //new Country("Cocos (Keeling) Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Colombia", "CO", "COL", "Republic of Colombia", "Bogotá", RegionType.SouthAmerica),
            new Country("Comoros", "KM", "COM", "Union of the Comoros", "Moroni", RegionType.Africa),
            new Country("Congo (Brazzaville)", "CG", "COG", "Republic of the Congo", "Brazzaville", RegionType.Africa),
            new Country("Congo (Kinshasa)", "CD", "COD", "Democratic Republic of the Congo", "Kinshasa", RegionType.Africa),
            //new Country("Cook Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Costa Rica", "CR", "CRI", "Republic of Costa Rica", "San José", RegionType.NorthAmerica),
            //new Country("Côte d'Ivoire", "CI", "CIV", "Republic of Côte d'Ivoire", "Yamoussoukro", RegionType.NorthAmerica),
            new Country("Croatia", "HR", "HRV", "Republic of Croatia", "Zagreb", RegionType.Europe),
            new Country("Cuba", "CU", "CUB", "Republic of Cuba", "Havana", RegionType.TheCaribbean),
            //new Country("Curacao", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            new Country("Cyprus", "CY", "CYP", "Republic of Cyprus", "Nicosia", RegionType.Europe),
            new Country("Czechia", "CZ", "CZE", "Czech Republic", "Prague", RegionType.Europe),
            new Country("Denmark", "DK", "DNK", "Kingdom of Denmark", "Copenhagen", RegionType.Europe),
            //new Country("Diego Garcia", "N", "N", "NULL", "NULL", RegionType.Asia),
            new Country("Djibouti", "DJ", "DJI", "Republic of Djibouti", "Djibouti", RegionType.Africa),
            new Country("Dominica", "DM", "DMA", "Commonwealth of Dominica", "Roseau", RegionType.TheCaribbean),
            new Country("Dominican Republic", "DO", "DOM", "Dominican Republic", "Santo Domingo", RegionType.TheCaribbean),
            new Country("Ecuador", "EC", "ECU", "Republic of Ecuador", "Quito", RegionType.SouthAmerica),
            new Country("Egypt", "EG", "EGY", "Arab Republic of Egypt", "Cairo", RegionType.Africa),
            new Country("El Salvador", "SV", "SLV", "Republic of El Salvador", "San Salvador", RegionType.NorthAmerica),
            new Country("Equatorial Guinea", "GQ", "GNQ", "Republic of Equatorial Guinea", "Malabo", RegionType.Africa),
            new Country("Eritrea", "ER", "ERI", "State of Eritrea", "Asmara", RegionType.Africa),
            new Country("Estonia", "EE", "EST", "Republic of Estonia", "Tallinn", RegionType.Europe),
            new Country("Ethiopia", "ET", "ETH", "Federal DemocraticRepublic of Ethiopia", "Addis Ababa", RegionType.Africa),
            //new Country("Falkland Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.SouthAmerica),
            //new Country("Faroe Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Europe),
            new Country("Fiji", "FJ", "FJI", "Republic of Fiji", "Suva", RegionType.Australasia),
            new Country("Finland", "FI", "FIN", "Republic of Finland", "Helsinki", RegionType.Europe),
            new Country("France", "FR", "FRA", "French Republic", "Paris", RegionType.Europe),
            //new Country("French Guiana", "AF", "AFG", "Afghanistan", "Kabul", RegionType.SouthAmerica),
            //new Country("French Polynesia", "N", "N", "NULL", "NULL", RegionType.Asia),
            //new Country("French Southern Territories", "N", "N", "NULL", "NULL", RegionType.Asia),
            new Country("Gabon", "GA", "GAB", "Gabonese Republic", "Libreville", RegionType.Africa),
            new Country("Gambia", "GM", "GMB", "Republic of The Gambia", "Banjul", RegionType.Africa),
            new Country("Georgia", "GE", "GEO", "Georgia", "Tbilisi", RegionType.Europe),
            new Country("Germany", "DE", "DEU", "Federal Republic of Germany", "Berlin", RegionType.Europe),
            new Country("Ghana", "GH", "GHA", "Republic of Ghana", "Accra", RegionType.Africa),
            //new Country("Gibraltar", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Europe),
            new Country("Greece", "GR", "GRC", "Hellenic Republic", "Athens", RegionType.Europe),
            //new Country("Greenland", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Europe),
            new Country("Grenada", "GD", "GRD", "Grenada", "Saint George's", RegionType.TheCaribbean),
            //new Country("Guadeloupe", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            //new Country("Guam", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Guatemala", "GT", "GTM", "Republic of Guatemala", "Guatemala City", RegionType.NorthAmerica),
            //new Country("Guernsey", "N", "N", "NULL", "NULL", RegionType.Asia),
            new Country("Guinea", "GN", "GIN", "Republic of Guinea", "Conakry", RegionType.Africa),
            new Country("Guinea-Bissau", "GW", "GNB", "Republic of Guinea Bissau", "Bissau", RegionType.Africa),
            new Country("Guyana", "GY", "GUY", "Co-operative Republic of Guyana", "Georgetown", RegionType.SouthAmerica),
            new Country("Haiti", "HT", "HTI", "Republic of Haiti", "Port-au-Prince", RegionType.TheCaribbean),
            //new Country("Heard & McDonald Islands", "N", "N", "NULL", "NULL", RegionType.A),
            new Country("Holy See", "VA", "VAT", "Holy See", "Vatican City", RegionType.Europe),
            new Country("Honduras", "HN", "HND", "Republic of Honduras", "Tegucigalpa", RegionType.NorthAmerica),
            //new Country("Hong Kong", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Asia),
            new Country("Hungary", "HU", "HUN", "Hungary", "Budapest", RegionType.Europe),
            new Country("Iceland", "IS", "ISL", "Republic of Iceland", "Reykjavík", RegionType.Europe),
            new Country("India", "IN", "IND", "Republic of India", "New Delhi", RegionType.Asia),
            new Country("Indonesia", "ID", "IDN", "Republic of Indonesia", "Jakarta", RegionType.Asia),
            new Country("Iran", "IR", "IRN", "Islamic Republic of Iran", "Tehran", RegionType.MiddleEast),
            new Country("Iraq", "IQ", "IRQ", "Republic of Iraq", "Baghdad", RegionType.MiddleEast),
            new Country("Ireland", "IE", "IRL", "Ireland", "Dublin", RegionType.Europe),
            //new Country("Isle of Man", "N", "N", "NULL", "NULL", RegionType.A),
            new Country("Israel", "IL", "ISR", "State of Israel", "Jerusalem", RegionType.MiddleEast),
            new Country("Italy", "IT", "ITA", "Italian Republic", "Rome", RegionType.Europe),
            //new Country("Ivory Coast (Cote D`Ivoire)", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Africa),
            new Country("Jamaica", "JM", "JAM", "Jamaica", "Kingston", RegionType.TheCaribbean),
            new Country("Japan", "JP", "JPN", "Japan", "Tokyo", RegionType.Asia),
            //new Country("Jersey", "N", "N", "NULL", "NULL", RegionType.A),
            new Country("Jordan", "JO", "JOR", "Hashemite Kingdom of Jordan", "Amman", RegionType.MiddleEast),
            new Country("Kazakhstan", "KZ", "KAZ", "Republic of Kazakhstan", "Astana", RegionType.Asia),
            new Country("Kenya", "KE", "KEN", "Republic of Kenya", "Nairobi", RegionType.Africa),
            new Country("Kiribati", "KI", "KIR", "Republic of Kiribati", "Tarawa", RegionType.Australasia),
            //new Country("Korea (North)", "KP", "PRK", "Democratic People's Republic of Korea", "Pyongyang", RegionType.Australasia),
            //new Country("Korea (South)", "KR", "KOR", "Republic of Korea", "Seoul", RegionType.Australasia),
            new Country("Kosovo", "XK", "XKS", "Republic of Kosovo", "Pristina", RegionType.Europe),
            new Country("Kuwait", "KW", "KWT", "State of Kuwait", "Kuwait City", RegionType.MiddleEast),
            new Country("Kyrgyzstan", "KG", "KGZ", "Kyrgyz Republic", "Bishkek", RegionType.Asia),
            new Country("Laos", "LA", "LAO", "Lao People's Democratic Republic", "Vientiane", RegionType.Asia),
            new Country("Latvia", "LV", "LVA", "Republic of Latvia", "Riga", RegionType.Europe),
            new Country("Lebanon", "LB", "LBN", "Lebanese Republic", "Beirut", RegionType.MiddleEast),
            new Country("Lesotho", "LS", "LSO", "Kingdom of Lesotho", "Maseru", RegionType.Africa),
            new Country("Liberia", "LR", "LBR", "Republic of Liberia", "Monrovia", RegionType.Africa),
            new Country("Libya", "LY", "LBY", "Libya", "Tripoli", RegionType.Africa),
            new Country("Liechtenstein", "LI", "LIE", "Principality of Liechtenstein", "Vaduz", RegionType.Europe),
            new Country("Lithuania", "LY", "LTU", "Republic of Lithuania", "Vilnius", RegionType.Europe),
            new Country("Luxembourg", "LU", "LUX", "Grand Duchy of Luxembourg", "Luxembourg", RegionType.Europe),
            //new Country("Macau", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Asia),
            new Country("Macedonia", "MK", "MKD", "Republic of Macedonia", "Skopje", RegionType.Europe),
            new Country("Madagascar", "MG", "MDG", "Republic of Madagascar", "Antananarivo", RegionType.Africa),
            new Country("Malawi", "MW", "MWI", "Republic of Malawi", "Lilongwe", RegionType.Africa),
            new Country("Malaysia", "MY", "MYS", "Malaysia", "Kuala Lumpur", RegionType.Asia),
            new Country("Maldives", "MV", "MDV", "Republic of Maldives", "Male", RegionType.Asia),
            new Country("Mali", "ML", "MLI", "Republic of Mali", "Bamako", RegionType.Africa),
            new Country("Malta", "MT", "MLT", "Republic of Malta", "Valletta", RegionType.Europe),
            new Country("Marshall Islands", "MH", "MHL", "Republic of the Marshall Islands", "Majuro", RegionType.Australasia),
            //new Country("Martinique", "MR", "MRT", "Islamic Republic of Mauritania", "Nouakchott", RegionType.TheCaribbean),
            new Country("Mauritania", "MR", "MRT", "Islamic Republic of Mauritania", "Nouakchott", RegionType.Africa),
            new Country("Mauritius", "MU", "MUS", "Republic of Mauritius", "Port Louis", RegionType.Africa),
            //new Country("Mayotte", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Africa),
            new Country("Mexico", "MX", "MEX", "United Mexican States", "Mexico City", RegionType.NorthAmerica),
            new Country("Micronesia", "FM", "FSM", "Federated States of Micronesia", "Palikir", RegionType.Australasia),
            new Country("Moldova", "MD", "MDA", "Republic of Moldova", "Chisinau", RegionType.Europe),
            new Country("Monaco", "MC", "MCO", "Principality of Monaco", "Monaco", RegionType.Europe),
            new Country("Mongolia", "MN", "MNG", "Mongolia", "Ulaanbaatar", RegionType.Asia),
            new Country("Montenegro", "ME", "MNE", "Montenegro", "Podgorica", RegionType.Europe),
            //new Country("Montserrat", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            new Country("Morocco", "MA", "MAR", "Kingdom of Morocco", "Rabat", RegionType.Africa),
            new Country("Mozambique", "MZ", "MOZ", "Republic of Mozambique", "Maputo", RegionType.Africa),
            //new Country("Myanmar (Burma)", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Asia),
            new Country("Namibia", "NA", "NAM", "Republic of Namibia", "Windhoek", RegionType.Africa),
            new Country("Nauru", "NR", "NRU", "Republic of Nauru", "Yaren District", RegionType.Australasia),
            new Country("Nepal", "NP", "NPL", "Federal Democratic Republic of Nepal", "Kathmandu", RegionType.Asia),
            new Country("Netherlands", "NL", "NLD", "Kingdom of the Netherlands", "Amsterdam", RegionType.Europe),
            //new Country("Netherlands Antilles", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            //new Country("New Caledonia", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("New Zealand", "NZ", "NZL", "New Zealand", "Wellington", RegionType.Australasia),
            new Country("Nicaragua", "NI", "NIC", "Republic of Nicaragua", "Managua", RegionType.NorthAmerica),
            new Country("Niger", "NE", "NER", "Republic of Niger", "Niamey", RegionType.Africa),
            new Country("Nigeria", "NG", "NGA", "Federal Republic of Nigeria", "Abuja", RegionType.Africa),
            //new Country("Niue", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            //new Country("Norfolk Island", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            //new Country("North Korea", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Asia),
            //new Country("Northern Mariana Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Asia),
            new Country("Norway", "NO", "NOR", "Kingdom of Norway", "Oslo", RegionType.Europe),
            new Country("Oman", "OM", "OMN", "Sultanate of Oman", "Muscat", RegionType.MiddleEast),
            new Country("Pakistan", "PK", "PAK", "Islamic Republic of Pakistan", "Islamabad", RegionType.Asia),
            new Country("Palau", "PW", "PLW", "Republic of Palau", "Ngerulmud", RegionType.Australasia),
            //new Country("Palestine", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Asia),
            new Country("Panama", "PA", "PAN", "Republic of Panama", "Panama City", RegionType.NorthAmerica),
            new Country("Papua New Guinea", "PG", "PNG", "Independent State of Papua New Guinea", "Port Moresby", RegionType.Australasia),
            new Country("Paraguay", "PY", "PRY", "Republic of Paraguay", "Asunción", RegionType.SouthAmerica),
            new Country("Peru", "PE", "PER", "Republic of Peru", "Lima", RegionType.SouthAmerica),
            new Country("Philippines", "PH", "PHL", "Republic of the Philippines", "Manila", RegionType.Asia),
            //new Country("Pitcairn Island", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Poland", "PL", "POL", "Republic of Poland", "Warsaw", RegionType.Europe),
            //new Country("Polynesia", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Portugal", "PT", "PRT", "Portuguese Republic", "Lisbon", RegionType.Europe),
            //new Country("Puerto Rico", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            new Country("Qatar", "QA", "QAT", "State of Qatar", "Doha", RegionType.MiddleEast),
            //new Country("Reunion", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Africa),
            new Country("Romania", "RO", "ROU", "Romania", "Bucharest", RegionType.Europe),
            new Country("Russia", "RU", "RUS", "Russian Federation", "Moscow", RegionType.Europe),
            new Country("Rwanda", "RW", "RWA", "Republic of Rwanda", "Kigali", RegionType.Africa),
            //new Country("Saint Barthelemy", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Africa),
            //new Country("Saint Helena", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Africa),
            new Country("Saint Kitts & Nevis", "KN", "KNA", "Federation of Saint Kitts and Nevis", "Basseterre", RegionType.TheCaribbean),
            new Country("Saint Lucia", "LC", "LCA", "Saint Lucia", "Castries", RegionType.TheCaribbean),
            //new Country("Saint Pierre & Miquelon", "AF", "AFG", "Afghanistan", "Kabul", RegionType.NorthAmerica),
            new Country("Saint Vincent & Grenadines", "VC", "VCT", "Saint Vincent and the Grenadines", "Kingstown", RegionType.TheCaribbean),
            new Country("Samoa", "WS", "WSM", "Independent State of Samoa", "Apia", RegionType.Australasia),
            new Country("San Marino", "SM", "SMR", "Republic of San Marino", "San Marino", RegionType.Europe),
            new Country("Sao Tome & Principe", "ST", "STP", "Democratic Republic of Sao Tome and Principe", "São Tomé", RegionType.Africa),
            new Country("Saudi Arabia", "SA", "SAU", "Kingdom of Saudi Arabia", "Riyadh", RegionType.MiddleEast),
            new Country("Senegal", "SN", "SEN", "Republic of Senegal", "Dakar", RegionType.Africa),
            new Country("Serbia", "RS", "SRB", "Republic of Serbia", "Belgrade", RegionType.Europe),
            new Country("Seychelles", "SC", "SYC", "Republic of Seychelles", "Victoria", RegionType.Africa),
            new Country("Sierra Leone", "SL", "SLE", "Republic of Sierra Leone", "Freetown", RegionType.Africa),
            new Country("Singapore", "SG", "SGP", "Republic of Singapore", "Singapore", RegionType.Asia),
            //new Country("Sint Maarten", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            new Country("Slovakia", "SK", "SVK", "Slovak Republic", "Bratislava", RegionType.Europe),
            new Country("Slovenia", "SI", "SVN", "Republic of Slovenia", "Ljubljana", RegionType.Europe),
            new Country("Solomon Islands", "SB", "SLB", "Solomon Islands", "Honiara", RegionType.Australasia),
            new Country("Somalia", "SO", "SOM", "Federal Republic of Somalia", "Mogadishu", RegionType.Africa),
            new Country("South Africa", "ZA", "ZAF", "Republic of South Africa", "Pretoria", RegionType.Africa),
            //new Country("South Georgia & South Sandwich Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.SouthAmerica),
            //new Country("South Korea", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Asia),
            new Country("South Sudan", "SS", "SSD", "Republic of South Sudan", "Juba", RegionType.Africa),
            new Country("Spain", "ES", "ESP", "Kingdom of Spain", "Madrid", RegionType.Europe),
            new Country("Sri Lanka", "LK", "LKA", "Democratic Socialist Republic of Sri Lanka", "Colombo", RegionType.Asia),
            //new Country("St. Vincent & Grenadines", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Europe),
            new Country("Sudan", "SD", "SDN", "Republic of the Sudan", "Khartoum", RegionType.Africa),
            new Country("Suriname", "SR", "SUR", "Republic of Suriname", "Paramaribo", RegionType.SouthAmerica),
            //new Country("Svalbard & Jan Mayen Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Europe),
            new Country("Swaziland", "SZ", "SWZ", "Kingdom of Swaziland", "Mbabane", RegionType.Africa),
            new Country("Sweden", "SE", "SWE", "Kingdom of Sweden", "Stockholm", RegionType.Europe),
            new Country("Switzerland", "CH", "CHE", "Swiss Confederation", "Bern", RegionType.Europe),
            new Country("Syria", "SY", "SYR", "Syrian Arab Republic", "Damascus", RegionType.MiddleEast),
            new Country("Taiwan", "TW", "TWN", "Taiwan", "Taipei", RegionType.Asia),
            new Country("Tajikistan", "TJ", "TJK", "Republic of Tajikistan", "Dushanbe", RegionType.Asia),
            new Country("Tanzania", "TZ", "TZA", "United Republic of Tanzania", "Dar es Salaam", RegionType.Africa),
            new Country("Thailand", "TH", "THA", "Kingdom of Thailand", "Bangkok", RegionType.Asia),
            new Country("Timor Leste", "TL", "THA", "Democratic Republic of Timor-Leste", "Dili", RegionType.Australasia),
            new Country("Togo", "TG", "TGO", "Togolese Republic", "Lomé", RegionType.Africa),
            //new Country("Tokelau", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Tonga", "TO", "TON", "Kingdom of Tonga", "Nuku'alofa", RegionType.Australasia),
            new Country("Trinidad & Tobago", "TT", "TTO", "Republic of Trinidad and Tobago", "Port of Spain", RegionType.TheCaribbean),
            //new Country("Tristan da Cunha", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Tunisia", "TN", "TUN", "Republic of Tunisia", "Tunis", RegionType.Africa),
            new Country("Turkey", "TR", "TUR", "Republic of Turkey", "Ankara", RegionType.MiddleEast),
            new Country("Turkmenistan", "TM", "TKM", "Turkmenistan", "Ashgabat", RegionType.Asia),
            new Country("Turks & Caicos Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.TheCaribbean),
            new Country("Tuvalu", "TV", "TUV", "Tuvalu", "Funafuti", RegionType.Australasia),
            //new Country("U.S. Outiying Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            //new Country("U.S. Virgin Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Uganda", "UG", "UGA", "Republic of Uganda", "Kampala", RegionType.Africa),
            new Country("Ukraine", "UA", "UKR", "Ukraine", "Kyiv", RegionType.Europe),
            new Country("United Arab Emirates", "AE", "ARE", "United Arab Emirates", "Abu Dhabi", RegionType.MiddleEast),
            new Country("United Kingdom", "GB", "GBR", "United Kingdom of Great Britain and Northern Ireland", "London", RegionType.Europe),
            new Country("United States", "US", "USA", "United States of America", "Washington, DC", RegionType.NorthAmerica),
            new Country("Uruguay", "UY", "URY", "Oriental Republic of Uruguay", "Montevideo", RegionType.SouthAmerica),
            new Country("Uzbekistan", "UZ", "UZB", "Republic of Uzbekistan", "Tashkent", RegionType.Asia),
            new Country("Vanuatu", "VU", "VUT", "Republic of Vanuatu", "Port-Vila", RegionType.Australasia),
            //new Country("Vatican City", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Venezuela", "VE", "VEN", "Bolivarian Republic of Venezuela", "Caracas", RegionType.SouthAmerica),
            new Country("Vietnam", "VN", "VNM", "Socialist Republic of Vietnam", "Hanoi", RegionType.Asia),
            //new Country("Wallis & Futuna Islands", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            //new Country("Western Sahara", "AF", "AFG", "Afghanistan", "Kabul", RegionType.Australasia),
            new Country("Yemen", "YE", "YEM", "Republic of Yemen", "Sanaa", RegionType.MiddleEast),
            new Country("Zambia", "ZM", "ZMB", "Republic of Zambia", "Lusaka", RegionType.Africa),
            new Country("Zimbabwe", "ZW", "ZWE", "Republic of Zimbabwe", "Harare", RegionType.Africa),





            /*
            new Country("Afghanistan", "Afghanistan", "af"),
            new Country("", "Albania", "al"),
            new Country("", "Algeria", "dz"),
            new Country("Angola", "Angola", "ao"),
            new Country("Antigua & Barbuda", "Antigua-and-Barbuda", "ag"),
            new Country("Argentina", "Argentina", "ar"),
            new Country("Armenia", "Armenia", "am"),
            new Country("Australia", "Australia", "au"),
            new Country("Austria", "Austria", "at"),
            new Country("Azerbaijan", "Azerbaijan", "az"),
            new Country("Bahamas", "Bahamas", "bs"),
            new Country("Bahrain", "Bahrain", "bh"),
            new Country("Bangladesh", "Bangladesh", "bd"),
            new Country("Barbados", "Barbados", "bb"),
            new Country("Belarus", "Belarus", "by"),
            new Country("Belgium", "Belgium", "be"),
            new Country("Belize", "Belize", "bz"),
            new Country("Benin", "Benin", "bj"),
            new Country("Bolivia", "Bolivia", "bo"),
            new Country("Bosnia & Herzegovina", "Bosnia-and-Herzegovina", "ba"),
            new Country("Brazil", "Brazil", "br"),
            new Country("Brunei", "Brunei", "bn"),
            new Country("Bulgaria", "Bulgaria", "bg"),
            new Country("Burkina Faso", "Burkina-Faso", "bf"),
            new Country("Cambodia", "Cambodia", "kh"),
            new Country("Canada", "Canada", "ca"),
            new Country("Central African Republic", "Central-African-Republic", "cf"),
            new Country("Chile", "Chile", "cl"),
            new Country("China", "China", "cn"),
            new Country("Colombia", "Colombia", "co"),
            new Country("Costa Rica", "Costa-Rica", "cr"),
            new Country("Côte d'Ivoire", "Cote-d'Ivoire", "ci"),
            new Country("Croatia", "Croatia", "hr"),
            new Country("Cuba", "Cuba", "cu"),
            new Country("Cyprus", "Cyprus", "cy"),
            new Country("Czech Republic", "Czech-Republic", "cz"),
            new Country("Denmark", "Denmark", "dk"),
            new Country("Dominican Republic", "Dominican-Republic", "do"),
            new Country("Ecuador", "Ecuador", "ec"),
            new Country("Egypt", "Egypt", "eg"),
            new Country("El Salvador", "El-Salvador", "sv"),
            new Country("Eritrea", "Eritrea", "er"),
            new Country("Estonia", "Estonia", "ee"),
            new Country("Ethiopia", "Ethiopia", "et"),
            new Country("Fiji", "Fiji", "fj"),
            new Country("Finland", "Finland", "fi"),
            new Country("France", "France", "fr"),
            new Country("Georgia", "Georgia", "ge"),
            new Country("Germany", "Germany", "de"),
            new Country("Ghana", "Ghana", "gh"),
            new Country("Greece", "Greece", "gr"),
            new Country("Guatemala", "Guatemala", "gt"),
            new Country("Guyana", "Guyana", "gy"),
            new Country("Haiti", "Haiti", "ht"),
            new Country("Honduras", "Honduras", "hn"),
            new Country("Hong Kong", "Hong-Kong", "hk"),
            new Country("Hungary", "Hungary", "hu"),
            new Country("Iceland", "Iceland", "is"),
            new Country("India", "India", "in"),
            new Country("Indonesia", "Indonesia", "id"),
            new Country("Iran", "Iran", "ir"),
            new Country("Iraq", "Iraq", "iq"),
            new Country("Ireland", "Ireland", "ie"),
            new Country("Israel", "Israel", "il"),
            new Country("Italy", "Italy", "it"),
            new Country("Jamaica", "Jamaica", "jm"),
            new Country("Japan", "Japan", "jp"),
            new Country("Jordan", "Jordan", "jo"),
            new Country("Kazakhstan", "Kazakhstan", "kz"),
            new Country("Kenya", "Kenya", "ke"),
            new Country("Kiribati", "Kiribati", "ki"),
            new Country("Kuwait", "Kuwait", "kw"),
            new Country("Kyrgyzstan", "Kyrgyzstan", "kg"),
            new Country("Laos", "Laos", "la"),
            new Country("Latvia", "Latvia", "lv"),
            new Country("Lebanon", "Lebanon", "lb"),
            new Country("Libya", "Libya", "ly"),
            new Country("Liechtenstein", "Liechtenstein", "li"),
            new Country("Lithuania", "Lithuania", "lt"),
            new Country("Luxembourg", "Luxembourg", "lu"),
            new Country("Macedonia", "Macedonia", "mk"),
            new Country("Malaysia", "Malaysia", "my"),
            new Country("Maldives", "Maldives", "mv"),
            new Country("Mali", "Mali", "ml"),
            new Country("Malta", "Malta", "mt"),
            new Country("Mauritania", "Mauritania", "mr"),
            new Country("Mauritius", "Mauritius", "mu"),
            new Country("Mexico", "Mexico", "mx"),
            new Country("Moldova", "Moldova", "md"),
            new Country("Mongolia", "Mongolia", "mn"),
            new Country("Montenegro", "Montenegro", "me"),
            new Country("Morocco", "Morocco", "ma"),
            new Country("Mozambique", "Mozambique", "mz"),
            new Country("Myanmar", "Myanmar", "mm"),
            new Country("Namibia", "Namibia", "na"),
            new Country("Nauru", "Nauru", "nr"),
            new Country("Nepal", "Nepal", "np"),
            new Country("Netherlands", "Netherlands", "nl"),
            new Country("New Zealand", "New-Zealand", "nz"),
            new Country("Nicaragua", "Nicaragua", "ni"),
            new Country("Nigeria", "Nigeria", "ng"),
            new Country("North Korea", "North-Korea", "kp"),
            new Country("Norway", "Norway", "no"),
            new Country("Oman", "Oman", "om"),
            new Country("Pakistan", "Pakistan", "pk"),
            new Country("Palestine", "Palestine", "ps"),
            new Country("Panama", "Panama", "pa"),
            new Country("Paraguay", "Paraguay", "py"),
            new Country("Peru", "Peru", "pe"),
            new Country("Philippines", "Philippines", "ph"),
            new Country("Poland", "Poland", "pl"),
            new Country("Portugal", "Portugal", "pt"),
            new Country("Qatar", "Qatar", "qa"),
            new Country("Romania", "Romania", "ro"),
            new Country("Russia", "Russia", "ru"),
            new Country("Saint Kitts & Nevis", "Saint-Kitts-and-Nevis", "kn"),
            new Country("Saint Lucia", "Saint-Lucia", "lc"),
            new Country("St. Vincent & Grenadines", "Saint-Vincent-and-the-Grenadines", "vc"),
            new Country("Saudi Arabia", "Saudi-Arabia", "sa"),
            new Country("Senegal", "Senegal", "sn"),
            new Country("Serbia", "Serbia", "rs"),
            new Country("Singapore", "Singapore", "sg"),
            new Country("Slovakia", "Slovakia", "sk"),
            new Country("Slovenia", "Slovenia", "si"),
            new Country("South Africa", "South-Africa", "za"),
            new Country("South Korea", "South-Korea", "kr"),
            new Country("South Sudan", "South-Sudan", "ss"),
            new Country("Spain", "Spain", "es"),
            new Country("Sri Lanka", "Sri-Lanka", "lk"),
            new Country("Sudan", "Sudan", "sd"),
            new Country("Suriname", "Suriname", "sr"),
            new Country("Sweden", "Sweden", "se"),
            new Country("Switzerland", "Switzerland", "ch"),
            new Country("Syria", "Syria", "sy"),
            new Country("Taiwan", "Taiwan", "tw"),
            new Country("Tajikistan", "Tajikistan", "tj"),
            new Country("Tanzania", "Tanzania", "tz"),
            new Country("Thailand", "Thailand", "th"),
            new Country("Trinidad & Tobago", "Trinidad-and-Tobago", "tt"),
            new Country("Tunisia", "Tunisia", "tn"),
            new Country("Turkey", "Turkey", "tr"),
            new Country("Turkmenistan", "Turkmenistan", "tm"),
            new Country("Tuvalu", "Tuvalu", "tv"),
            new Country("Uganda", "Uganda", "ug"),
            new Country("Ukraine", "Ukraine", "ua"),
            new Country("United Arab Emirates", "United-Arab-Emirates", "ae"),
            new Country("United Kingdom", "United-Kingdom", "gb"),
            new Country("United States", "United-States", "us"),
            new Country("Uruguay", "Uruguay", "uy"),
            new Country("Uzbekistan", "Uzbekistan", "uz"),
            new Country("Venezuela", "Venezuela", "ve"),
            new Country("Vietnam", "Vietnam", "vn"),
            new Country("Yemen", "Yemen", "ye"),
            new Country("Zambia", "Zambia", "zm"),
            new Country("Zimbabwe", "Zimbabwe", "zw")
            */
        };

        public static Country GetCountryFor2ID(string id, CountryIDType type = CountryIDType.A2) {
            if (!string.IsNullOrEmpty(id)) {
                string mid = id.Trim().ToLower();
                foreach (Country current in CountryCollection.ListOfCountries) {
                    if(type == CountryIDType.A2) {
                        if (current.Code2A == mid) {
                            return current;
                        }
                    } else if (type == CountryIDType.A3) {
                        if (current.Code3A == mid) {
                            return current;
                        }
                    }
                    
                }
            }
            return Country.EMPTY;
        }


        public static List<string> GetAllCountryNames(CountryNameType type = CountryNameType.Short) {
            List<string> list = new List<string>();
            foreach (Country country in CountryCollection.ListOfCountries) {
                if(type == CountryNameType.Short) {
                    list.Add(country.ShortName.Trim().ToUpper());
                } else if(type == CountryNameType.Long) {
                    list.Add(country.LongName.Trim().ToUpper());
                } else if (type == CountryNameType.Capital) {
                    list.Add(country.Capital.Trim().ToUpper());
                }
            }
            return list;
        }

        public static int GetAllCountryCount() {
            return CountryCollection.ListOfCountries.Count;
        }
    }
}


