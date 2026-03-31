// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
/// </summary>
[IsoId("_QE8vddp-Ed-ak6NoX_4Aeg_-1605328291")]
[DisplayName("Financial Institution Identification")]
public record FinancialInstitutionIdentification6
{
    /// <summary>
    /// Unique and unambiguous identifier of a clearing system member, as assigned by the system or system administrator.
    /// </summary>
    [IsoId("_QE8vdtp-Ed-ak6NoX_4Aeg_1518346993")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_QE8vd9p-Ed-ak6NoX_4Aeg_-256066049")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification4? ProprietaryIdentification { get; init; }

    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QE8veNp-Ed-ak6NoX_4Aeg_1879167964")]
    [DisplayName("BIC")]
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public IsoBICIdentifier? BIC { get; init; }
}
