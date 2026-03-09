// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Filter to compute the totals.
/// </summary>
[IsoId("_Qu5qgN6TEeiwsev40qZGEQ")]
[DisplayName("Total Filter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalFilter1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier of the POI system performing a reconciliation.
    /// </summary>
    [IsoId("_Y6snQN6TEeiwsev40qZGEQ")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIIdentification { get; init; } 
    #else
    public System.String? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the sale terminal (electronic cash register or point of sale terminal) or the sale system.
    /// </summary>
    [IsoId("_b2wIsN6TEeiwsev40qZGEQ")]
    [DisplayName("Sale Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleId")]
    #endif
    [IsoXmlTag("SaleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleIdentification { get; init; } 
    #else
    public System.String? SaleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cashier who carried out the transaction.
    /// </summary>
    [IsoId("_fp-isN6TEeiwsev40qZGEQ")]
    [DisplayName("Cashier Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshrId")]
    #endif
    [IsoXmlTag("CshrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CashierIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashierIdentification { get; init; } 
    #else
    public System.String? CashierIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the shift of the cashier.
    /// </summary>
    [IsoId("_idX3YN6TEeiwsev40qZGEQ")]
    [DisplayName("Shift Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShftNb")]
    #endif
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShiftNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShiftNumber { get; init; } 
    #else
    public System.String? ShiftNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a group of transaction on a POI Terminal, having the same Sale features.
    /// </summary>
    [IsoId("_l1j7MN6TEeiwsev40qZGEQ")]
    [DisplayName("Totals Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlsGrpId")]
    #endif
    [IsoXmlTag("TtlsGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TotalsGroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalsGroupIdentification { get; init; } 
    #else
    public System.String? TotalsGroupIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
