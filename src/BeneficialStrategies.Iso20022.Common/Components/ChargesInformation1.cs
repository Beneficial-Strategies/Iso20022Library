// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the charges related to the payment transaction.
/// </summary>
[IsoId("_RtjsAtp-Ed-ak6NoX_4Aeg_-450206740")]
[DisplayName("Charges Information")]
public partial record ChargesInformation1
{
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_RtjsA9p-Ed-ak6NoX_4Aeg_1765318183")]
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public required CurrencyAndAmount ChargesAmount { get; init; } 
    
    /// <summary>
    /// Party that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_RtjsBNp-Ed-ak6NoX_4Aeg_1407518272")]
    [DisplayName("Charges Party")]
    [IsoXmlTag("ChrgsPty")]
    public required BranchAndFinancialInstitutionIdentification3 ChargesParty { get; init; } 
    
    
    #nullable disable
    
}
