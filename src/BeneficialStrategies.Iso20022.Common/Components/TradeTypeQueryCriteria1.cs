// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the query criteria related to transaction types.
/// </summary>
[IsoId("_HbKEkN33EemPzZ9FnkQP2A")]
[DisplayName("Trade Type Query Criteria")]
public partial record TradeTypeQueryCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the AND/OR operators as query criteria.
    /// </summary>
    [IsoId("_PwpTYN34EemPzZ9FnkQP2A")]
    [DisplayName("Operator")]
    [IsoXmlTag("Oprtr")]
    public required Operation3Code Operator { get; init; } 
    
    /// <summary>
    /// Query criteria related to the type of the securities financing transaction.
    /// </summary>
    [IsoId("_Ec35EN34EemPzZ9FnkQP2A")]
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public ExposureType6Code? SecuritiesFinancingTransactionType { get; init; } 
    
    /// <summary>
    /// Query criteria related to the type of the collateral component.
    /// </summary>
    [IsoId("_FfoWkN34EemPzZ9FnkQP2A")]
    [DisplayName("Collateral Component Type")]
    [IsoXmlTag("CollCmpntTp")]
    public CollateralType6Code? CollateralComponentType { get; init; } 
    
    
    #nullable disable
    
}
