// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identifiers for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.CHIPSUniversalIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.NewZealandNCCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.IrishNSCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.UKDomesticSortCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.CHIPSParticipantIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.SwissBCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.FedwireRoutingNumberIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.PortugueseNCCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.RussianCentralBankIdentificationCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.ItalianDomesticIdentificationCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.AustrianBankleitzahlIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.CanadianPaymentsAssociationRoutingNumberIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.SwissSICIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.GermanBankleitzahlIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.SpanishDomesticInterbankingIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.SouthAfricanNCCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.HongKongBankCode))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.AustralianExtensiveBranchNetworkIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentification4Choice.AustralianSmallNetworkIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.CHIPSUniversalIdentification),nameof(ClearingSystemMemberIdentification4Choice.CHIPSUniversalIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.NewZealandNCCIdentification),nameof(ClearingSystemMemberIdentification4Choice.NewZealandNCCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.IrishNSCIdentification),nameof(ClearingSystemMemberIdentification4Choice.IrishNSCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.UKDomesticSortCode),nameof(ClearingSystemMemberIdentification4Choice.UKDomesticSortCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.CHIPSParticipantIdentification),nameof(ClearingSystemMemberIdentification4Choice.CHIPSParticipantIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.SwissBCIdentification),nameof(ClearingSystemMemberIdentification4Choice.SwissBCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.FedwireRoutingNumberIdentification),nameof(ClearingSystemMemberIdentification4Choice.FedwireRoutingNumberIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.PortugueseNCCIdentification),nameof(ClearingSystemMemberIdentification4Choice.PortugueseNCCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.RussianCentralBankIdentificationCode),nameof(ClearingSystemMemberIdentification4Choice.RussianCentralBankIdentificationCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.ItalianDomesticIdentificationCode),nameof(ClearingSystemMemberIdentification4Choice.ItalianDomesticIdentificationCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.AustrianBankleitzahlIdentification),nameof(ClearingSystemMemberIdentification4Choice.AustrianBankleitzahlIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.CanadianPaymentsAssociationRoutingNumberIdentification),nameof(ClearingSystemMemberIdentification4Choice.CanadianPaymentsAssociationRoutingNumberIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.SwissSICIdentification),nameof(ClearingSystemMemberIdentification4Choice.SwissSICIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.GermanBankleitzahlIdentification),nameof(ClearingSystemMemberIdentification4Choice.GermanBankleitzahlIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.SpanishDomesticInterbankingIdentification),nameof(ClearingSystemMemberIdentification4Choice.SpanishDomesticInterbankingIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.SouthAfricanNCCIdentification),nameof(ClearingSystemMemberIdentification4Choice.SouthAfricanNCCIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.HongKongBankCode),nameof(ClearingSystemMemberIdentification4Choice.HongKongBankCode))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.AustralianExtensiveBranchNetworkIdentification),nameof(ClearingSystemMemberIdentification4Choice.AustralianExtensiveBranchNetworkIdentification))]
    [JsonDerivedType(typeof(ClearingSystemMemberIdentification4Choice.AustralianSmallNetworkIdentification),nameof(ClearingSystemMemberIdentification4Choice.AustralianSmallNetworkIdentification))]
    [IsoId("_Vgzb8bNIEeejueAciesPMA")]
    [DisplayName("Clearing System Member Identification 4 Choice")]
    public abstract partial record ClearingSystemMemberIdentification4Choice_
    {
    }
}
