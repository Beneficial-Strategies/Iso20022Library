// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Element containing all information needed for a card initiating direct debit.
/// </summary>
[IsoId("_sk2rwNprEeearpaEPXv9UA")]
[DisplayName("Card Direct Debit")]
public record CardDirectDebit1
{
    /// <summary>
    /// Information related to the debtor.
    /// </summary>
    [IsoId("_8npZ8NprEeearpaEPXv9UA")]
    [DisplayName("Debtor Identification")]
    [IsoXmlTag("DbtrId")]
    public Debtor3? DebtorIdentification { get; init; }

    /// <summary>
    /// Information related to the creditor.
    /// </summary>
    [IsoId("_Gz814NpsEeearpaEPXv9UA")]
    [DisplayName("Creditor Identification")]
    [IsoXmlTag("CdtrId")]
    public required Creditor3 CreditorIdentification { get; init; }

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("_OPR_ANpsEeearpaEPXv9UA")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public required MandateRelatedInformation13 MandateRelatedInformation { get; init; }
}
