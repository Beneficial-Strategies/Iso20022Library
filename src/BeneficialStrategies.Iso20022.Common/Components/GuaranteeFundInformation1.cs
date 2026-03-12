// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Owner and account number of the guarantee fund.
/// </summary>
[IsoId("__ATdACchEeaBPexHR4QTEw")]
[DisplayName("Guarantee Fund Information")]
public partial record GuaranteeFundInformation1
{
    #nullable enable
    
    /// <summary>
    /// Guarantee fund account identifier.
    /// </summary>
    [IsoId("_iCd_QCciEeaBPexHR4QTEw")]
    [DisplayName("Guarantee Fund Account")]
    [IsoXmlTag("GrntFndAcct")]
    public required CashAccount24 GuaranteeFundAccount { get; init; } 
    
    /// <summary>
    /// Owner identification of the guarantee fund.
    /// </summary>
    [IsoId("_p7GvcCciEeaBPexHR4QTEw")]
    [DisplayName("Guarantee Fund Account Owner")]
    [IsoXmlTag("GrntFndAcctOwnr")]
    public required FinancialInstitutionIdentification9 GuaranteeFundAccountOwner { get; init; } 
    
    
    #nullable disable
    
}
