// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that contains the information of the contract agreed between both parties.
/// </summary>
[IsoId("_UkjHQtp-Ed-ak6NoX_4Aeg_15886237")]
[DisplayName("Contract Document")]
public record ContractDocument1
{
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_UkjHQ9p-Ed-ak6NoX_4Aeg_392681280")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; }

    /// <summary>
    /// Signoff date of the document.
    /// </summary>
    [IsoId("_UkjHRNp-Ed-ak6NoX_4Aeg_564641730")]
    [DisplayName("Sign Off Date")]
    [IsoXmlTag("SgnOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SignOffDate { get; init; }

    /// <summary>
    /// Identification of the version of the contract.
    /// </summary>
    [IsoId("_UkjHRdp-Ed-ak6NoX_4Aeg_618206750")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public IsoMax6Text? Version { get; init; }
}
