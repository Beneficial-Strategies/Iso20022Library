// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identifiers for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.CHIPSUniversalIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.NewZealandNCCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.IrishNSCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.UKDomesticSortCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.CHIPSParticipantIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.SwissBCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.FedwireRoutingNumberIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.PortugueseNCCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.RussianCentralBankIdentificationCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.ItalianDomesticIdentificationCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.AustrianBankleitzahlIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.CanadianPaymentsAssociationRoutingNumberIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.SwissSICIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.GermanBankleitzahlIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.SpanishDomesticInterbankingIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.SouthAfricanNCCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.HongKongBankCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.AustralianExtensiveBranchNetworkIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.AustralianSmallNetworkIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.IndianFinancialSystemCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.HellenicBankIdentificationCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.PolishNationalClearingCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification2Choice.OtherClearingCodeIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.CHIPSUniversalIdentification),nameof(ClearingSystemMemberIdentification2Choice.CHIPSUniversalIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.NewZealandNCCIdentification),nameof(ClearingSystemMemberIdentification2Choice.NewZealandNCCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.IrishNSCIdentification),nameof(ClearingSystemMemberIdentification2Choice.IrishNSCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.UKDomesticSortCode),nameof(ClearingSystemMemberIdentification2Choice.UKDomesticSortCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.CHIPSParticipantIdentification),nameof(ClearingSystemMemberIdentification2Choice.CHIPSParticipantIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.SwissBCIdentification),nameof(ClearingSystemMemberIdentification2Choice.SwissBCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.FedwireRoutingNumberIdentification),nameof(ClearingSystemMemberIdentification2Choice.FedwireRoutingNumberIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.PortugueseNCCIdentification),nameof(ClearingSystemMemberIdentification2Choice.PortugueseNCCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.RussianCentralBankIdentificationCode),nameof(ClearingSystemMemberIdentification2Choice.RussianCentralBankIdentificationCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.ItalianDomesticIdentificationCode),nameof(ClearingSystemMemberIdentification2Choice.ItalianDomesticIdentificationCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.AustrianBankleitzahlIdentification),nameof(ClearingSystemMemberIdentification2Choice.AustrianBankleitzahlIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.CanadianPaymentsAssociationRoutingNumberIdentification),nameof(ClearingSystemMemberIdentification2Choice.CanadianPaymentsAssociationRoutingNumberIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.SwissSICIdentification),nameof(ClearingSystemMemberIdentification2Choice.SwissSICIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.GermanBankleitzahlIdentification),nameof(ClearingSystemMemberIdentification2Choice.GermanBankleitzahlIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.SpanishDomesticInterbankingIdentification),nameof(ClearingSystemMemberIdentification2Choice.SpanishDomesticInterbankingIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.SouthAfricanNCCIdentification),nameof(ClearingSystemMemberIdentification2Choice.SouthAfricanNCCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.HongKongBankCode),nameof(ClearingSystemMemberIdentification2Choice.HongKongBankCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.AustralianExtensiveBranchNetworkIdentification),nameof(ClearingSystemMemberIdentification2Choice.AustralianExtensiveBranchNetworkIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.AustralianSmallNetworkIdentification),nameof(ClearingSystemMemberIdentification2Choice.AustralianSmallNetworkIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.IndianFinancialSystemCode),nameof(ClearingSystemMemberIdentification2Choice.IndianFinancialSystemCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.HellenicBankIdentificationCode),nameof(ClearingSystemMemberIdentification2Choice.HellenicBankIdentificationCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.PolishNationalClearingCode),nameof(ClearingSystemMemberIdentification2Choice.PolishNationalClearingCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification2Choice.OtherClearingCodeIdentification),nameof(ClearingSystemMemberIdentification2Choice.OtherClearingCodeIdentification))]
    [IsoId("_TCzAqtp-Ed-ak6NoX_4Aeg_1989939445")]
    [DisplayName("Clearing System Member Identification 2 Choice")]
    public abstract partial record ClearingSystemMemberIdentification2Choice_
    {
    }
}
