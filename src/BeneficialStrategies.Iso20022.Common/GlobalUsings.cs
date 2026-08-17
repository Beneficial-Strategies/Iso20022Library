// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

// For source code clarity, the primative types used in this implementation are represented in source code as their ISO-declared types.
// Because too many were clashing with Microsoft framework types, all names are prefixed with 'Iso' for disambiguation.

// Global namespace usings required by generated code
global using System.ComponentModel;
global using System.Runtime.Serialization;
global using System.Text.Json.Serialization;
global using BeneficialStrategies.Iso20022.Amounts;
global using BeneficialStrategies.Iso20022.Codesets;
global using BeneficialStrategies.Iso20022.SimpleTypes;

global using BeneficialStrategies.Iso20022.Framework;
global using BeneficialStrategies.Iso20022.Metadata;
global using BeneficialStrategies.Iso20022.Serialization;

global using Isoint = BeneficialStrategies.Iso20022.SimpleTypes.XsdInt;
global using Isolong = BeneficialStrategies.Iso20022.SimpleTypes.XsdLong;
global using Isoshort = BeneficialStrategies.Iso20022.SimpleTypes.XsdShort;
global using Isobyte = BeneficialStrategies.Iso20022.SimpleTypes.XsdByte;
global using IsounsignedByte = BeneficialStrategies.Iso20022.SimpleTypes.XsdUnsignedByte;
global using IsounsignedInt = BeneficialStrategies.Iso20022.SimpleTypes.XsdUnsignedInt;
global using IsounsignedLong = BeneficialStrategies.Iso20022.SimpleTypes.XsdUnsignedLong;
global using IsounsignedShort = BeneficialStrategies.Iso20022.SimpleTypes.XsdUnsignedShort;
global using Isointeger = BeneficialStrategies.Iso20022.SimpleTypes.XsdInteger;
global using IsopositiveInteger = BeneficialStrategies.Iso20022.SimpleTypes.XsdPositiveInteger;
global using IsonegativeInteger = BeneficialStrategies.Iso20022.SimpleTypes.XsdNegativeInteger;
global using IsononNegativeInteger = BeneficialStrategies.Iso20022.SimpleTypes.XsdNonNegativeInteger;
global using IsononPositiveInteger = BeneficialStrategies.Iso20022.SimpleTypes.XsdNonPositiveInteger;
// XSD boolean/floating-point type aliases — W3C xs:boolean/float/double
global using Isoboolean = BeneficialStrategies.Iso20022.SimpleTypes.XsdBoolean;
global using Isofloat = BeneficialStrategies.Iso20022.SimpleTypes.XsdFloat;
global using Isodouble = BeneficialStrategies.Iso20022.SimpleTypes.XsdDouble;
// XSD Gregorian/duration/URI type aliases — W3C xs:gYear/gYearMonth/gMonth/gMonthDay/gDay/duration/anyURI
global using IsogYear = BeneficialStrategies.Iso20022.SimpleTypes.XsdGYear;
global using IsogYearMonth = BeneficialStrategies.Iso20022.SimpleTypes.XsdGYearMonth;
global using IsogMonth = BeneficialStrategies.Iso20022.SimpleTypes.XsdGMonth;
global using IsogMonthDay = BeneficialStrategies.Iso20022.SimpleTypes.XsdGMonthDay;
global using IsogDay = BeneficialStrategies.Iso20022.SimpleTypes.XsdGDay;
global using Isoduration = BeneficialStrategies.Iso20022.SimpleTypes.XsdDuration;
global using IsoanyURI = BeneficialStrategies.Iso20022.SimpleTypes.XsdAnyURI;
// XSD string subtype / binary type aliases — W3C xs:normalizedString/token/language/hexBinary/base64Binary
global using IsonormalizedString = BeneficialStrategies.Iso20022.SimpleTypes.XsdNormalizedString;
global using Isotoken = BeneficialStrategies.Iso20022.SimpleTypes.XsdToken;
global using Isolanguage = BeneficialStrategies.Iso20022.SimpleTypes.XsdLanguage;
global using IsohexBinary = BeneficialStrategies.Iso20022.SimpleTypes.XsdHexBinary;
global using Isobase64Binary = BeneficialStrategies.Iso20022.SimpleTypes.XsdBase64Binary;
// Remaining SimpleTypes aliases
global using IsoExtended350Code = BeneficialStrategies.Iso20022.SimpleTypes.Extended350Code;
global using IsoExternalLocalInstrumentCode_Obsolete = BeneficialStrategies.Iso20022.SimpleTypes.ExternalLocalInstrumentCode_Obsolete;
global using IsoMin3Max4Text = BeneficialStrategies.Iso20022.SimpleTypes.Min3Max4Text;
global using IsoMin5Max8Text = BeneficialStrategies.Iso20022.SimpleTypes.Min5Max8Text;
global using IsoMin6Max8Text = BeneficialStrategies.Iso20022.SimpleTypes.Min6Max8Text;
global using IsoMax10KText = BeneficialStrategies.Iso20022.SimpleTypes.Max10KText;
global using IsoMax20KText = BeneficialStrategies.Iso20022.SimpleTypes.Max20KText;
global using IsoMax40KText = BeneficialStrategies.Iso20022.SimpleTypes.Max40KText;
global using IsoMax10MbText = BeneficialStrategies.Iso20022.SimpleTypes.Max10MbText;
global using IsoPhoneNumber = BeneficialStrategies.Iso20022.SimpleTypes.PhoneNumber;
global using IsoSHA256SignatureText = BeneficialStrategies.Iso20022.SimpleTypes.SHA256SignatureText;
global using IsoHexBinaryText = BeneficialStrategies.Iso20022.SimpleTypes.HexBinaryText;
global using IsoDateOffsetText = BeneficialStrategies.Iso20022.SimpleTypes.DateOffsetText;
global using IsoGeographicPointInDecimalDegrees = BeneficialStrategies.Iso20022.SimpleTypes.GeographicPointInDecimalDegrees;
global using IsoGeographicPointInDecimalDegreesText = BeneficialStrategies.Iso20022.SimpleTypes.GeographicPointInDecimalDegreesText;
global using IsoRefused7Text = BeneficialStrategies.Iso20022.SimpleTypes.Refused7Text;
global using IsoRateSourceText = BeneficialStrategies.Iso20022.SimpleTypes.RateSourceText;
global using IsoPreviousAll = BeneficialStrategies.Iso20022.SimpleTypes.PreviousAll;
global using IsoUnlimited9Text = BeneficialStrategies.Iso20022.SimpleTypes.Unlimited9Text;
global using IsoMax10DateText = BeneficialStrategies.Iso20022.SimpleTypes.Max10DateText;
global using IsoJulianDate = BeneficialStrategies.Iso20022.SimpleTypes.JulianDate;
global using IsoMax8HexBinaryText = BeneficialStrategies.Iso20022.SimpleTypes.Max8HexBinaryText;
global using IsoMax16HexBinaryText = BeneficialStrategies.Iso20022.SimpleTypes.Max16HexBinaryText;
global using IsoMax19HexBinaryText = BeneficialStrategies.Iso20022.SimpleTypes.Max19HexBinaryText;
global using IsoMax32HexBinaryText = BeneficialStrategies.Iso20022.SimpleTypes.Max32HexBinaryText;
global using IsoMax9999HexBinaryText = BeneficialStrategies.Iso20022.SimpleTypes.Max9999HexBinaryText;
global using IsoMax10KHexBinaryText = BeneficialStrategies.Iso20022.SimpleTypes.Max10KHexBinaryText;
global using IsoMax6AlphaText = BeneficialStrategies.Iso20022.SimpleTypes.Max6AlphaText;
global using IsoMin2Max3AlphaText = BeneficialStrategies.Iso20022.SimpleTypes.Min2Max3AlphaText;
// Identifier and financial-code aliases
global using IsoBICFIIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.BICFIIdentifier;
global using IsoBICIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.BICIdentifier;
global using IsoBICNonFIIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.BICNonFIIdentifier;
global using IsoAnyBICIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.AnyBICIdentifier;
global using IsoBEIIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.BEIIdentifier;
global using IsoBICFIDec2014Identifier = BeneficialStrategies.Iso20022.SimpleTypes.BICFIDec2014Identifier;
global using IsoBICNonFIDec2014Identifier = BeneficialStrategies.Iso20022.SimpleTypes.BICNonFIDec2014Identifier;
global using IsoAnyBICDec2014Identifier = BeneficialStrategies.Iso20022.SimpleTypes.AnyBICDec2014Identifier;
global using IsoIBANIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.IBANIdentifier;
global using IsoIBAN2007Identifier = BeneficialStrategies.Iso20022.SimpleTypes.IBAN2007Identifier;
global using IsoBBANIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.BBANIdentifier;
global using IsoAustrianBankleitzahlIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.AustrianBankleitzahlIdentifier;
global using IsoCanadianPaymentsARNIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.CanadianPaymentsARNIdentifier;
global using IsoCHIPSParticipantIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.CHIPSParticipantIdentifier;
global using IsoCHIPSUniversalIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.CHIPSUniversalIdentifier;
global using IsoExtensiveBranchNetworkIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.ExtensiveBranchNetworkIdentifier;
global using IsoFedwireRoutingNumberIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.FedwireRoutingNumberIdentifier;
global using IsoGermanBankleitzahlIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.GermanBankleitzahlIdentifier;
global using IsoHellenicBankIdentificationCodeIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.HellenicBankIdentificationCodeIdentifier;
global using IsoHongKongBankIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.HongKongBankIdentifier;
global using IsoIndianFinancialSystemCodeIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.IndianFinancialSystemCodeIdentifier;
global using IsoIrishNSCIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.IrishNSCIdentifier;
global using IsoItalianDomesticIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.ItalianDomesticIdentifier;
global using IsoNewZealandNCCIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.NewZealandNCCIdentifier;
global using IsoPolishNationalClearingCodeIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.PolishNationalClearingCodeIdentifier;
global using IsoPortugueseNCCIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.PortugueseNCCIdentifier;
global using IsoRussianCentralBankIdentificationCodeIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.RussianCentralBankIdentificationCodeIdentifier;
global using IsoSmallNetworkIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.SmallNetworkIdentifier;
global using IsoSouthAfricanNCCIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.SouthAfricanNCCIdentifier;
global using IsoSpanishDomesticInterbankingIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.SpanishDomesticInterbankingIdentifier;
global using IsoSwissBCIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.SwissBCIdentifier;
global using IsoSwissSICIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.SwissSICIdentifier;
global using IsoUKDomesticSortCodeIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.UKDomesticSortCodeIdentifier;
global using IsoISINIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.ISINIdentifier;
global using IsoISINOct2015Identifier = BeneficialStrategies.Iso20022.SimpleTypes.ISINOct2015Identifier;
global using IsoISIN2021Identifier = BeneficialStrategies.Iso20022.SimpleTypes.ISIN2021Identifier;
global using IsoLEIIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.LEIIdentifier;
global using IsoMICIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.MICIdentifier;
global using IsoCFIIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.CFIIdentifier;
global using IsoCFIOct2015Identifier = BeneficialStrategies.Iso20022.SimpleTypes.CFIOct2015Identifier;
global using IsoEICIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.EICIdentifier;
global using IsoIBEIIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.IBEIIdentifier;
global using IsoISICIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.ISICIdentifier;
global using IsoUPICIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.UPICIdentifier;
global using IsoDunsIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.DunsIdentifier;
global using IsoEANGLNIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.EANGLNIdentifier;
global using IsoMerchantCategoryCodeIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.MerchantCategoryCodeIdentifier;
global using IsoNACEDomainIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.NACEDomainIdentifier;
global using IsoNACEDomain2025Identifier = BeneficialStrategies.Iso20022.SimpleTypes.NACEDomain2025Identifier;
global using IsoBloomberg2Identifier = BeneficialStrategies.Iso20022.SimpleTypes.Bloomberg2Identifier;
global using IsoDTI2021Identifier = BeneficialStrategies.Iso20022.SimpleTypes.DTI2021Identifier;
global using IsoDTI2024Identifier = BeneficialStrategies.Iso20022.SimpleTypes.DTI2024Identifier;
global using IsoEntryTypeIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.EntryTypeIdentifier;
global using IsoUUIDv4Identifier = BeneficialStrategies.Iso20022.SimpleTypes.UUIDv4Identifier;
global using IsoUTIIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.UTIIdentifier;
global using IsoISO20022MessageIdentificationText = BeneficialStrategies.Iso20022.SimpleTypes.ISO20022MessageIdentificationText;
global using IsoBloombergIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.BloombergIdentifier;
global using IsoConsolidatedTapeAssociationIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.ConsolidatedTapeAssociationIdentifier;
global using IsoEuroclearClearstreamIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.EuroclearClearstreamIdentifier;
global using IsoRICIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.RICIdentifier;
global using IsoTickerIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.TickerIdentifier;
global using IsoYesNoIndicator = BeneficialStrategies.Iso20022.SimpleTypes.YesNoIndicator;
global using IsoTrueFalseIndicator = BeneficialStrategies.Iso20022.SimpleTypes.TrueFalseIndicator;
global using IsoPlusOrMinusIndicator = BeneficialStrategies.Iso20022.SimpleTypes.PlusOrMinusIndicator;
global using IsoAMLIndicator = BeneficialStrategies.Iso20022.SimpleTypes.AMLIndicator;
global using IsoBatchBookingIndicator = BeneficialStrategies.Iso20022.SimpleTypes.BatchBookingIndicator;
global using IsoChargeIncludedIndicator = BeneficialStrategies.Iso20022.SimpleTypes.ChargeIncludedIndicator;
global using IsoGroupCancellationIndicator = BeneficialStrategies.Iso20022.SimpleTypes.GroupCancellationIndicator;
global using IsoGroupingIndicator = BeneficialStrategies.Iso20022.SimpleTypes.GroupingIndicator;
global using IsoIdentificationVerificationIndicator = BeneficialStrategies.Iso20022.SimpleTypes.IdentificationVerificationIndicator;
global using IsoOverrideIndicator = BeneficialStrategies.Iso20022.SimpleTypes.OverrideIndicator;
global using IsoPaymentDirectionIndicator = BeneficialStrategies.Iso20022.SimpleTypes.PaymentDirectionIndicator;
global using IsoRequestedIndicator = BeneficialStrategies.Iso20022.SimpleTypes.RequestedIndicator;
global using IsoRestrictedFINMax8Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax8Text;
global using IsoRestrictedFINMax15Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax15Text;
global using IsoRestrictedFINMax16Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax16Text;
global using IsoRestrictedFINMax23Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax23Text;
global using IsoRestrictedFINMax30Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax30Text;
global using IsoRestrictedFINMax31Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax31Text;
global using IsoRestrictedFINMax34Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax34Text;
global using IsoRestrictedFINMax35Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax35Text;
global using IsoRestrictedFINMax50Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax50Text;
global using IsoRestrictedFINMax210Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINMax210Text;
global using IsoRestrictedFINZMax256Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINZMax256Text;
global using IsoRestrictedFINZMax2048Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINZMax2048Text;
global using IsoRestrictedFINZMax8000Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINZMax8000Text;
global using IsoRestrictedFINXMax8Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax8Text;
global using IsoRestrictedFINXMax16Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax16Text;
global using IsoRestrictedFINXMax24Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax24Text;
global using IsoRestrictedFINXMax25Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax25Text;
global using IsoRestrictedFINXMax30Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax30Text;
global using IsoRestrictedFINXMax31Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax31Text;
global using IsoRestrictedFINXMax34Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax34Text;
global using IsoRestrictedFINXMax35Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax35Text;
global using IsoRestrictedFINXMax52Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax52Text;
global using IsoRestrictedFINXMax70Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax70Text;
global using IsoRestrictedFINXMax140Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax140Text;
global using IsoRestrictedFINXMax210Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax210Text;
global using IsoRestrictedFINXMax256Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax256Text;
global using IsoRestrictedFINXMax350Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax350Text;
global using IsoRestrictedFINXMax520Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINXMax520Text;
global using IsoRestrictedFINX2Max34Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINX2Max34Text;
// IsoXxx aliases for Groups A/B/C/D pattern-restricted simple types
global using IsoMax2NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max2NumericText;
global using IsoMax3NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max3NumericText;
global using IsoMax4NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max4NumericText;
global using IsoMax5NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max5NumericText;
global using IsoMax6NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max6NumericText;
global using IsoMax8NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max8NumericText;
global using IsoMax9NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max9NumericText;
global using IsoMax10NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max10NumericText;
global using IsoMax11NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max11NumericText;
global using IsoMax12NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max12NumericText;
global using IsoMax15NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max15NumericText;
global using IsoMax19NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max19NumericText;
global using IsoMax23NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max23NumericText;
global using IsoMax35NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max35NumericText;
global using IsoExact1NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact1NumericText;
global using IsoExact2NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact2NumericText;
global using IsoExact3NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact3NumericText;
global using IsoExact4NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact4NumericText;
global using IsoExact5NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact5NumericText;
global using IsoExact7NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact7NumericText;
global using IsoExact14NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact14NumericText;
global using IsoMin2Max3NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Min2Max3NumericText;
global using IsoMin3Max4NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Min3Max4NumericText;
global using IsoMin8Max28NumericText = BeneficialStrategies.Iso20022.SimpleTypes.Min8Max28NumericText;
global using IsoMax15PlusSignedNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max15PlusSignedNumericText;
global using IsoMax4AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max4AlphaNumericText;
global using IsoMax5AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max5AlphaNumericText;
global using IsoMax15AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max15AlphaNumericText;
global using IsoMax20AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Max20AlphaNumericText;
global using IsoExact2AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact2AlphaNumericText;
global using IsoExact3AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact3AlphaNumericText;
global using IsoExact4AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact4AlphaNumericText;
global using IsoExact32AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact32AlphaNumericText;
global using IsoExact1Text = BeneficialStrategies.Iso20022.SimpleTypes.Exact1Text;
global using IsoExact10Text = BeneficialStrategies.Iso20022.SimpleTypes.Exact10Text;
global using IsoExact12Text = BeneficialStrategies.Iso20022.SimpleTypes.Exact12Text;
global using IsoExact15Text = BeneficialStrategies.Iso20022.SimpleTypes.Exact15Text;
global using IsoExact42Text = BeneficialStrategies.Iso20022.SimpleTypes.Exact42Text;
global using IsoExact2UpperCaseAlphaText = BeneficialStrategies.Iso20022.SimpleTypes.Exact2UpperCaseAlphaText;
global using IsoExact3UpperCaseAlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact3UpperCaseAlphaNumericText;
global using IsoExact1AlphaText = BeneficialStrategies.Iso20022.SimpleTypes.Exact1AlphaText;
global using IsoExact6AlphaNumericText = BeneficialStrategies.Iso20022.SimpleTypes.Exact6AlphaNumericText;
global using IsoExact4AlphaNumericUnderscoreText = BeneficialStrategies.Iso20022.SimpleTypes.Exact4AlphaNumericUnderscoreText;
global using IsoRestrictedFINExact2Text = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINExact2Text;
global using IsoExact1HexBinaryText = BeneficialStrategies.Iso20022.SimpleTypes.Exact1HexBinaryText;
global using IsoMax3Text = BeneficialStrategies.Iso20022.SimpleTypes.Max3Text;
global using IsoMax4Text = BeneficialStrategies.Iso20022.SimpleTypes.Max4Text;
global using IsoMax6Text = BeneficialStrategies.Iso20022.SimpleTypes.Max6Text;
global using IsoMax8Text = BeneficialStrategies.Iso20022.SimpleTypes.Max8Text;
global using IsoMax10Text = BeneficialStrategies.Iso20022.SimpleTypes.Max10Text;
global using IsoMax12Text = BeneficialStrategies.Iso20022.SimpleTypes.Max12Text;
global using IsoMax15Text = BeneficialStrategies.Iso20022.SimpleTypes.Max15Text;
global using IsoMax16Text = BeneficialStrategies.Iso20022.SimpleTypes.Max16Text;
global using IsoMax20Text = BeneficialStrategies.Iso20022.SimpleTypes.Max20Text;
global using IsoMax25Text = BeneficialStrategies.Iso20022.SimpleTypes.Max25Text;
global using IsoMax30Text = BeneficialStrategies.Iso20022.SimpleTypes.Max30Text;
global using IsoMax34Text = BeneficialStrategies.Iso20022.SimpleTypes.Max34Text;
global using IsoMax35Text = BeneficialStrategies.Iso20022.SimpleTypes.Max35Text;
global using IsoMax36Text = BeneficialStrategies.Iso20022.SimpleTypes.Max36Text;
global using IsoMax37Text = BeneficialStrategies.Iso20022.SimpleTypes.Max37Text;
global using IsoMax40Text = BeneficialStrategies.Iso20022.SimpleTypes.Max40Text;
global using IsoMax45Text = BeneficialStrategies.Iso20022.SimpleTypes.Max45Text;
global using IsoMax48Text = BeneficialStrategies.Iso20022.SimpleTypes.Max48Text;
global using IsoMax50Text = BeneficialStrategies.Iso20022.SimpleTypes.Max50Text;
global using IsoMax52Text = BeneficialStrategies.Iso20022.SimpleTypes.Max52Text;
global using IsoMax60Text = BeneficialStrategies.Iso20022.SimpleTypes.Max60Text;
global using IsoMax64Text = BeneficialStrategies.Iso20022.SimpleTypes.Max64Text;
global using IsoMax70Text = BeneficialStrategies.Iso20022.SimpleTypes.Max70Text;
global using IsoMax72Text = BeneficialStrategies.Iso20022.SimpleTypes.Max72Text;
global using IsoMax76Text = BeneficialStrategies.Iso20022.SimpleTypes.Max76Text;
global using IsoMax99Text = BeneficialStrategies.Iso20022.SimpleTypes.Max99Text;
global using IsoMax100Text = BeneficialStrategies.Iso20022.SimpleTypes.Max100Text;
global using IsoMax104Text = BeneficialStrategies.Iso20022.SimpleTypes.Max104Text;
global using IsoMax105Text = BeneficialStrategies.Iso20022.SimpleTypes.Max105Text;
global using IsoMax128Text = BeneficialStrategies.Iso20022.SimpleTypes.Max128Text;
global using IsoMax140Text = BeneficialStrategies.Iso20022.SimpleTypes.Max140Text;
global using IsoMax200Text = BeneficialStrategies.Iso20022.SimpleTypes.Max200Text;
global using IsoMax210Text = BeneficialStrategies.Iso20022.SimpleTypes.Max210Text;
global using IsoMax240Text = BeneficialStrategies.Iso20022.SimpleTypes.Max240Text;
global using IsoMax256Text = BeneficialStrategies.Iso20022.SimpleTypes.Max256Text;
global using IsoMax280Text = BeneficialStrategies.Iso20022.SimpleTypes.Max280Text;
global using IsoMax350Text = BeneficialStrategies.Iso20022.SimpleTypes.Max350Text;
global using IsoMax450Text = BeneficialStrategies.Iso20022.SimpleTypes.Max450Text;
global using IsoMax500Text = BeneficialStrategies.Iso20022.SimpleTypes.Max500Text;
global using IsoMax512Text = BeneficialStrategies.Iso20022.SimpleTypes.Max512Text;
global using IsoMax1000Text = BeneficialStrategies.Iso20022.SimpleTypes.Max1000Text;
global using IsoMax1025Text = BeneficialStrategies.Iso20022.SimpleTypes.Max1025Text;
global using IsoMax2000Text = BeneficialStrategies.Iso20022.SimpleTypes.Max2000Text;
global using IsoMax2048Text = BeneficialStrategies.Iso20022.SimpleTypes.Max2048Text;
global using IsoMax4000Text = BeneficialStrategies.Iso20022.SimpleTypes.Max4000Text;
global using IsoMax8000Text = BeneficialStrategies.Iso20022.SimpleTypes.Max8000Text;
global using IsoMax20000Text = BeneficialStrategies.Iso20022.SimpleTypes.Max20000Text;

global using IsoISODateTime = BeneficialStrategies.Iso20022.SimpleTypes.ISODateTime; // date+time, 3 permitted wire forms (UTC/offset/local) — see SimpleTypes/ISODateTime.cs
global using IsoISONormalisedDateTime = BeneficialStrategies.Iso20022.SimpleTypes.ISONormalisedDateTime; // ISODateTime restricted to always-UTC (pattern .*Z) — see SimpleTypes/ISONormalisedDateTime.cs
global using IsoISODate = System.DateOnly; // Date
global using IsoSEDOLIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.SEDOLIdentifier; // IdentifierSet; London Stock Exchange proprietary format, no ISO-stated pattern
global using IsoCUSIPIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.CUSIPIdentifier; // IdentifierSet; CUSIP Bureau proprietary format, no ISO-stated pattern
global using IsoQUICKIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.QUICKIdentifier; // IdentifierSet; Japanese QUICK proprietary format, no ISO-stated pattern
global using IsoWertpapierIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.WertpapierIdentifier; // IdentifierSet; German WKN, ISO-stated 6-digit format
global using IsoDutchIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.DutchIdentifier; // IdentifierSet; Dutch securities proprietary format, no ISO-stated pattern
global using IsoValorenIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.ValorenIdentifier; // IdentifierSet; Swiss Telekurs proprietary format, no ISO-stated pattern
global using IsoSicovamIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.SicovamIdentifier; // IdentifierSet; French Sicovam, ISO-stated 5-digit format
global using IsoBelgianIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.BelgianIdentifier; // IdentifierSet; Belgian securities proprietary format, no ISO-stated pattern
global using IsoRatingValueIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.RatingValueIdentifier; // IdentifierSet; rating agency proprietary values, no ISO-stated pattern
global using IsoSNA2008SectorIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.SNA2008SectorIdentifier; // IdentifierSet; UN SNA 2008 hierarchical sector codes, no ISO-stated pattern
// global using IsoDirectionIndicator = System.String; // Not in current ISO 20022 snapshot — cannot convert
global using IsoNumber = BeneficialStrategies.Iso20022.SimpleTypes.Number; // Quantity; totalDigits=18, signed (no minInclusive facet) — was wrongly unsigned as System.UInt64
global using IsoDecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.DecimalNumber; // Quantity; totalDigits=18/fractionDigits=17 — was wrongly integer-typed as System.UInt64 despite being decimal-shaped
global using IsoMax3Number = BeneficialStrategies.Iso20022.SimpleTypes.Max3Number; // Quantity; totalDigits=3, signed per companion NumberRule constraint — was wrongly unsigned as System.UInt64
global using IsoRestrictedFINDecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedFINDecimalNumber; // Quantity; totalDigits=14/fractionDigits=14 (all-fractional) — was wrongly integer-typed as System.UInt64
global using IsoNonNegativeDecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.NonNegativeDecimalNumber; // Quantity; minInclusive=0, totalDigits=18/fractionDigits=17 — was wrongly integer-typed as System.UInt64
global using IsoLongDecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.LongDecimalNumber; // Quantity; totalDigits=22/fractionDigits=11 — was wrongly integer-typed as System.UInt64
global using IsoRestrictedMonthExact2Number = BeneficialStrategies.Iso20022.SimpleTypes.RestrictedMonthExact2Number; // Quantity; exact 2-digit zero-padded wire form (pattern "[0-9]{2,2}") — the padding was lost via the previous System.UInt64 alias
global using IsoPositiveNumber = BeneficialStrategies.Iso20022.SimpleTypes.PositiveNumber; // Quantity; minInclusive=1, totalDigits=18
global using IsoMax5Number = BeneficialStrategies.Iso20022.SimpleTypes.Max5Number; // Quantity; totalDigits=5, signed per companion NumberRule constraint — was wrongly unsigned as System.UInt64
global using IsoMax1Number = BeneficialStrategies.Iso20022.SimpleTypes.Max1Number; // Quantity; totalDigits=1, signed (no minInclusive facet) — was wrongly unsigned as System.UInt64
global using IsoDecimalNumberFraction5 = BeneficialStrategies.Iso20022.SimpleTypes.DecimalNumberFraction5; // Quantity; Obsolete in ISO 20022 (removalDate 2020-02-01); totalDigits=18/fractionDigits=5 — was wrongly integer-typed as System.UInt64
global using IsoLongFraction21DecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.LongFraction21DecimalNumber; // Quantity; totalDigits=22/fractionDigits=21 — was wrongly integer-typed as System.UInt64
global using IsoNonNegativeFraction5DecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.NonNegativeFraction5DecimalNumber; // Quantity; minInclusive=0, totalDigits=18/fractionDigits=5 — was wrongly integer-typed as System.UInt64
global using IsoNonNegativeNumber = BeneficialStrategies.Iso20022.SimpleTypes.NonNegativeNumber; // Quantity; minInclusive=0, totalDigits=18
global using IsoMax20PositiveNumber = BeneficialStrategies.Iso20022.SimpleTypes.Max20PositiveNumber; // Quantity; minInclusive=0 (despite the name — verified via MCP, not assumed), totalDigits=20 exceeds System.UInt64's practical range, decimal-backed
global using IsoMax20PositiveDecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.Max20PositiveDecimalNumber; // Quantity; minInclusive=0, totalDigits=20/fractionDigits=2 — was wrongly integer-typed as System.UInt64
global using IsoMax6NumberFraction2 = BeneficialStrategies.Iso20022.SimpleTypes.Max6NumberFraction2; // Quantity; totalDigits=6/fractionDigits=2 — was wrongly integer-typed as System.UInt64
global using IsoMax10NumberFraction2 = BeneficialStrategies.Iso20022.SimpleTypes.Max10NumberFraction2; // Quantity; totalDigits=10/fractionDigits=2 — was wrongly integer-typed as System.UInt64
global using IsoFraction5DecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.Fraction5DecimalNumber; // Quantity; totalDigits=18/fractionDigits=5 — was wrongly integer-typed as System.UInt64
global using IsoMax2Fraction1NonNegativeNumber = BeneficialStrategies.Iso20022.SimpleTypes.Max2Fraction1NonNegativeNumber; // Quantity; minInclusive=0, maxInclusive=9.9, fractionDigits=1 — was wrongly integer-typed as System.UInt64
global using IsoLongFraction19DecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.LongFraction19DecimalNumber; // Quantity; totalDigits=25/fractionDigits=19 — was wrongly integer-typed as System.UInt64
global using IsoDayOfMonthNumber = BeneficialStrategies.Iso20022.SimpleTypes.DayOfMonthNumber; // Quantity; minInclusive=1, maxInclusive=31
global using IsoMax30DecimalNumber = BeneficialStrategies.Iso20022.SimpleTypes.Max30DecimalNumber; // Quantity; totalDigits=30/fractionDigits=29 — exceeds System.Decimal's ~28-29 significant digits, documented practical limitation; was wrongly integer-typed as System.UInt64
global using IsoMax5PositiveNumber = BeneficialStrategies.Iso20022.SimpleTypes.Max5PositiveNumber; // Quantity; minInclusive=1, totalDigits=5
global using IsoMax10PositiveNumber = BeneficialStrategies.Iso20022.SimpleTypes.Max10PositiveNumber; // Quantity; minInclusive=1, totalDigits=10
global using IsoISOTime = BeneficialStrategies.Iso20022.SimpleTypes.ISOTime; // Time; 3 permitted wire forms (UTC/offset/local) per MCP — see SimpleTypes/ISOTime.cs; the previous System.TimeOnly alias couldn't hold the timezone
global using IsoPercentageRate = BeneficialStrategies.Iso20022.SimpleTypes.PercentageRate; // Rate; totalDigits=11/fractionDigits=10 — plain System.Decimal didn't enforce ISO's precision/magnitude bound
global using IsoPercentageBoundedRate = BeneficialStrategies.Iso20022.SimpleTypes.PercentageBoundedRate; // Rate; minInclusive=0, maxInclusive=100, fractionDigits=10
global using IsoBaseOneRate = BeneficialStrategies.Iso20022.SimpleTypes.BaseOneRate; // Rate; totalDigits=11/fractionDigits=10
global using IsoBaseOne14Rate = BeneficialStrategies.Iso20022.SimpleTypes.BaseOne14Rate; // Rate; totalDigits=14/fractionDigits=13
global using IsoPercentage = BeneficialStrategies.Iso20022.SimpleTypes.Percentage; // Rate; Obsolete in ISO 20022 (removalDate 2017-01-05); totalDigits=11/fractionDigits=10
global using IsoBaseOne18Rate = BeneficialStrategies.Iso20022.SimpleTypes.BaseOne18Rate; // Rate; totalDigits=18/fractionDigits=13
global using IsoBaseOne25Rate = BeneficialStrategies.Iso20022.SimpleTypes.BaseOne25Rate; // Rate; totalDigits=25/fractionDigits=13, "may contain values larger than 1"
global using IsoISOYearMonth = BeneficialStrategies.Iso20022.SimpleTypes.ISOYearMonth; // YearMonth; "YYYY-MM" composite — the previous System.UInt16 alias (max 65535) couldn't hold this shape at all
global using IsoISOYear = BeneficialStrategies.Iso20022.SimpleTypes.ISOYear; // Year; 4-digit zero-padded wire form — the previous System.UInt16 alias didn't zero-pad
global using IsoISORestrictedYear = BeneficialStrategies.Iso20022.SimpleTypes.ISORestrictedYear; // Year; minInclusive=1900, maxInclusive=2099
global using IsoMax10KBinary = BeneficialStrategies.Iso20022.SimpleTypes.Max10KBinary; // Binary; minLength=1, maxLength=10240 (10K = 10*1024) — was unvalidated System.Byte[]
global using IsoMax2MBBinary = BeneficialStrategies.Iso20022.SimpleTypes.Max2MBBinary; // Binary; minLength=1, maxLength=2097152 (2MB = 2*1024*1024) — was unvalidated System.Byte[]
global using IsoMax10000Binary = BeneficialStrategies.Iso20022.SimpleTypes.Max10000Binary; // Binary; minLength=1, maxLength=10000 — was unvalidated System.Byte[]
global using IsoMax3000Binary = BeneficialStrategies.Iso20022.SimpleTypes.Max3000Binary; // Binary; minLength=1, maxLength=3000 — was unvalidated System.Byte[]
global using IsoMax35Binary = BeneficialStrategies.Iso20022.SimpleTypes.Max35Binary; // Binary; minLength=1, maxLength=35 — was unvalidated System.Byte[]
global using IsoMax500Binary = BeneficialStrategies.Iso20022.SimpleTypes.Max500Binary; // Binary; minLength=1, maxLength=500 — was unvalidated System.Byte[]
global using IsoMax140Binary = BeneficialStrategies.Iso20022.SimpleTypes.Max140Binary; // Binary; minLength=1, maxLength=140 — was unvalidated System.Byte[]
global using IsoMin5Max16Binary = BeneficialStrategies.Iso20022.SimpleTypes.Min5Max16Binary; // Binary; minLength=5, maxLength=16 — was unvalidated System.Byte[]
global using IsoMax5000Binary = BeneficialStrategies.Iso20022.SimpleTypes.Max5000Binary; // Binary; minLength=1, maxLength=5000 — was unvalidated System.Byte[]
global using IsoMax100KBinary = BeneficialStrategies.Iso20022.SimpleTypes.Max100KBinary; // Binary; minLength=1, maxLength=102400 (100K = 100*1024) — was unvalidated System.Byte[]
global using IsoMax2KBinary = BeneficialStrategies.Iso20022.SimpleTypes.Max2KBinary; // Binary; minLength=1, maxLength=2048 (2K = 2*1024) — was unvalidated System.Byte[]
global using IsoMax10MbBinary = BeneficialStrategies.Iso20022.SimpleTypes.Max10MbBinary; // Binary; minLength=1, maxLength=10485760 (10MB = 10*1024*1024) — was unvalidated System.Byte[]
global using IsoMin1Max256Binary = BeneficialStrategies.Iso20022.SimpleTypes.Min1Max256Binary; // Binary; minLength=1, maxLength=256 — was unvalidated System.Byte[]
global using IsoMax16Binary = BeneficialStrategies.Iso20022.SimpleTypes.Max16Binary; // Binary; minLength=1, maxLength=16 — was unvalidated System.Byte[]
global using IsoExact20Binary = BeneficialStrategies.Iso20022.SimpleTypes.Exact20Binary; // Binary; exact length=20 (minLength=maxLength=20) — was unvalidated System.Byte[]
global using IsoMax20MbBinary = BeneficialStrategies.Iso20022.SimpleTypes.Max20MbBinary; // Binary; minLength=1, maxLength=20971520 (20MB = 20*1024*1024) — was unvalidated System.Byte[]
global using IsoanySimpleType = System.String; // W3C xs:anySimpleType — abstract root of the XSD simple-type hierarchy; no narrower representation possible without knowing the concrete runtime type
global using Isodate = System.DateOnly; // W3C xs:date — matches IsoISODate's existing choice for the same concept
global using IsodateTime = BeneficialStrategies.Iso20022.SimpleTypes.ISODateTime; // W3C xs:dateTime — reuses the struct built for ISO's own ISODateTime (plain DateTime can't capture the 3 permitted wire forms)
global using Isodecimal = System.Decimal; // W3C xs:decimal — matches the many Iso*Rate/Iso*Number aliases already using System.Decimal directly in this file
global using IsoENTITIES = System.String; // W3C xs:ENTITIES — DTD-era entity reference list; vestigial in schema-based XML, zero live usage, no meaningful BCL/struct mapping exists
global using IsoENTITY = System.String; // W3C xs:ENTITY — DTD-era entity reference; vestigial in schema-based XML, zero live usage, no meaningful BCL/struct mapping exists
global using IsoID = BeneficialStrategies.Iso20022.SimpleTypes.XsdID; // W3C xs:ID — 4 live usages; lexical shape only, document-wide uniqueness is a cross-element constraint this type can't enforce alone
global using IsoIDREF = BeneficialStrategies.Iso20022.SimpleTypes.XsdIDREF; // W3C xs:IDREF — same lexical shape as XsdID/XsdNCName
global using IsoIDREFS = BeneficialStrategies.Iso20022.SimpleTypes.XsdIDREFS; // W3C xs:IDREFS — whitespace-separated list of IDREF
global using IsoName = BeneficialStrategies.Iso20022.SimpleTypes.XsdName; // W3C xs:Name — XML 1.0 Name production (ASCII-range approximation, see type remarks)
global using IsoNCName = BeneficialStrategies.Iso20022.SimpleTypes.XsdNCName; // W3C xs:NCName — Name without a colon (ASCII-range approximation, see type remarks)
global using IsoNMTOKEN = BeneficialStrategies.Iso20022.SimpleTypes.XsdNMTOKEN; // W3C xs:NMTOKEN — XML 1.0 Nmtoken production (ASCII-range approximation, see type remarks)
global using IsoNMTOKENS = BeneficialStrategies.Iso20022.SimpleTypes.XsdNMTOKENS; // W3C xs:NMTOKENS — whitespace-separated list of NMTOKEN
global using IsoQName = System.Xml.XmlQualifiedName; // W3C xs:QName — verified real value equality from source (see CLAUDE.md "Class-typed properties..."); wired into Iso20022XmlSerializer's leaf-type dispatch and a dedicated JSON converter (Iso20022XmlQualifiedNameJsonConverter) — see FormatQName/ParseQName for the prefix-resolution details a QName's context-dependent lexical form requires
global using Isostring = System.String; // W3C xs:string — already the exact correct mapping, not an oversight
global using Isotime = System.TimeOnly; // W3C xs:time — matches IsoISOTime's existing choice for the same concept
global using IsoISOMonth = System.Byte; // Month
global using IsoNPIIdentifier = BeneficialStrategies.Iso20022.SimpleTypes.NPIIdentifier; // IdentifierSet; ISO 24366 format given in prose (13 upper-case alphanumeric + 2 check digits), pattern derived from that text
global using IsoPercentage14Rate = System.Decimal; // Rate
global using IsoATICALaxProcessing = BeneficialStrategies.Iso20022.ExternalSchema.ATICALaxProcessing;
global using IsoLaxPayload = BeneficialStrategies.Iso20022.ExternalSchema.LaxPayload;
global using IsoSignatureEnvelope = BeneficialStrategies.Iso20022.ExternalSchema.SignatureEnvelope;
