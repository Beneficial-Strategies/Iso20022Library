// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_zjvwkTchEeOA3chqL9a4Rw")]
[DisplayName("Settlement Parties")]
public record SettlementParties35
{
    /// <summary>
    /// Parties through which settlement is to take place.
    /// </summary>
    [IsoId("_-Rf3QTciEeOKPpUjhHfcCQ")]
    [DisplayName("Standing Settlement Parties")]
    [IsoXmlTag("StgSttlmPties")]
    public required SettlementParties32 StandingSettlementParties { get; init; }

    /// <summary>
    /// Identifier needed for settlement purposes. This identifier could be, for example, an identifier that identifies an institution or agent at a CDS or ICSD (Depository Trust Clearing Corporation (DTC) Institution ID or DTC Agent ID). It could also be a local tax identification number or an ‘investor identification’, as mandated by local market practice.
    /// </summary>
    [IsoId("_HjKEoNQiEeKvJeoOII0e7w")]
    [DisplayName("Local Market Identification")]
    [IsoXmlTag("LclMktId")]
    public GenericIdentification49? LocalMarketIdentification { get; init; }

    /// <summary>
    /// Registration information required for settlement. For some markets, for example, Spain (Iberclear) registration details are mandatory and should be part of the SSI. In some cases, the name of the institution is different than what&apos;s provided in the BIC Directory. If this is the case, the name should be provided.
    /// </summary>
    [IsoId("_XT29QNQiEeKvJeoOII0e7w")]
    [DisplayName("Registration Details")]
    [IsoXmlTag("RegnDtls")]
    public PartyIdentification99Choice_? RegistrationDetails { get; init; }
}
