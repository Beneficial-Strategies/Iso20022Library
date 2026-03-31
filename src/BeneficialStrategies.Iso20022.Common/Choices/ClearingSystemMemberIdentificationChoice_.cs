// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of identifiers for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.CHIPSUniversalIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.NewZealandNCCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.IrishNSCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.UKDomesticSortCode))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.CHIPSParticipantIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.SwissBCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.FedwireRoutingNumberIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.PortugueseNCCIdentification))]
    [KnownType(
        typeof(ClearingSystemMemberIdentificationChoice.RussianCentralBankIdentificationCode)
    )]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.ItalianDomesticIdentificationCode))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.AustrianBankleitzahlIdentification))]
    [KnownType(
        typeof(ClearingSystemMemberIdentificationChoice.CanadianPaymentsAssociationRoutingNumberIdentification)
    )]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.SwissSICIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.GermanBankleitzahlIdentification))]
    [KnownType(
        typeof(ClearingSystemMemberIdentificationChoice.SpanishDomesticInterbankingIdentification)
    )]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.SouthAfricanNCCIdentification))]
    [KnownType(typeof(ClearingSystemMemberIdentificationChoice.HongKongBankCode))]
    [KnownType(
        typeof(ClearingSystemMemberIdentificationChoice.AustralianExtensiveBranchNetworkIdentification)
    )]
    [KnownType(
        typeof(ClearingSystemMemberIdentificationChoice.AustralianSmallNetworkIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.CHIPSUniversalIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.CHIPSUniversalIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.NewZealandNCCIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.NewZealandNCCIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.IrishNSCIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.IrishNSCIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.UKDomesticSortCode),
        nameof(ClearingSystemMemberIdentificationChoice.UKDomesticSortCode)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.CHIPSParticipantIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.CHIPSParticipantIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.SwissBCIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.SwissBCIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.FedwireRoutingNumberIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.FedwireRoutingNumberIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.PortugueseNCCIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.PortugueseNCCIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.RussianCentralBankIdentificationCode),
        nameof(ClearingSystemMemberIdentificationChoice.RussianCentralBankIdentificationCode)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.ItalianDomesticIdentificationCode),
        nameof(ClearingSystemMemberIdentificationChoice.ItalianDomesticIdentificationCode)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.AustrianBankleitzahlIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.AustrianBankleitzahlIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.CanadianPaymentsAssociationRoutingNumberIdentification),
        nameof(
            ClearingSystemMemberIdentificationChoice.CanadianPaymentsAssociationRoutingNumberIdentification
        )
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.SwissSICIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.SwissSICIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.GermanBankleitzahlIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.GermanBankleitzahlIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.SpanishDomesticInterbankingIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.SpanishDomesticInterbankingIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.SouthAfricanNCCIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.SouthAfricanNCCIdentification)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.HongKongBankCode),
        nameof(ClearingSystemMemberIdentificationChoice.HongKongBankCode)
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.AustralianExtensiveBranchNetworkIdentification),
        nameof(
            ClearingSystemMemberIdentificationChoice.AustralianExtensiveBranchNetworkIdentification
        )
    )]
    [JsonDerivedType(
        typeof(ClearingSystemMemberIdentificationChoice.AustralianSmallNetworkIdentification),
        nameof(ClearingSystemMemberIdentificationChoice.AustralianSmallNetworkIdentification)
    )]
    [IsoId("_TDPFhtp-Ed-ak6NoX_4Aeg_-896562614")]
    [DisplayName("Clearing System Member Identification Choice")]
    public abstract record ClearingSystemMemberIdentificationChoice_ { }
}
