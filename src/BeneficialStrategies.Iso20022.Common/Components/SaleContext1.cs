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
/// Sale context in which the transaction is performed.
/// </summary>
[IsoId("_SwsDzAEcEeCQm6a_G2yO_w_1953670809")]
[DisplayName("Sale Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleContext1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the sale terminal (electronic cash register) or the sale system.
    /// </summary>
    [IsoId("_SwsDzQEcEeCQm6a_G2yO_w_-1301262192")]
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
    /// Identify a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_SwsDzgEcEeCQm6a_G2yO_w_-1321065836")]
    [DisplayName("Sale Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRefNb")]
    #endif
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReferenceNumber { get; init; } 
    #else
    public System.String? SaleReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the reconciliation between the Sale system and the POI system.
    /// </summary>
    [IsoId("_Sw1NsAEcEeCQm6a_G2yO_w_-1796156354")]
    [DisplayName("Sale Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRcncltnId")]
    #endif
    [IsoXmlTag("SaleRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReconciliationIdentification { get; init; } 
    #else
    public System.String? SaleReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cashier who carried out the transaction.
    /// </summary>
    [IsoId("_Sw1NsQEcEeCQm6a_G2yO_w_1983014102")]
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
    [IsoId("_Sw1NsgEcEeCQm6a_G2yO_w_1568063427")]
    [DisplayName("Shift Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShftNb")]
    #endif
    [IsoXmlTag("ShftNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShiftNumber { get; init; } 
    #else
    public System.String? ShiftNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information associated with the sale transaction.
    /// </summary>
    [IsoId("_Sw1NswEcEeCQm6a_G2yO_w_842115279")]
    [DisplayName("Additional Sale Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSaleData")]
    #endif
    [IsoXmlTag("AddtlSaleData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalSaleData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalSaleData { get; init; } 
    #else
    public System.String? AdditionalSaleData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
