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
/// Reference to the collateral management transaction (exposure) or the contract identification of  the sender (collateral taker) or the receiver (triparty agent)
/// </summary>
[IsoId("_dOIDYPkCEeicy5Zn42b9bg")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference identifying the collateral management transaction (exposure) from the collateral taker&apos;s or the collateral giver point of view.
    /// </summary>
    [IsoId("_Z6qcoPkEEeicy5Zn42b9bg")]
    [DisplayName("Sender Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrCollTxId")]
    #endif
    [IsoXmlTag("SndrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SenderCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? SenderCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the collateral management transaction (exposure)  from the triparty agent&apos;s point of view.
    /// </summary>
    [IsoId("_o8Z9gPkEEeicy5Zn42b9bg")]
    [DisplayName("Receiver Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrCollTxId")]
    #endif
    [IsoXmlTag("RcvrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReceiverCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiverCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? ReceiverCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the collateral management contract from the collateral taker&apos;s or the collateral giver&apos;s point of view.
    /// </summary>
    [IsoId("_eQJZsPkFEeicy5Zn42b9bg")]
    [DisplayName("Sender Collateral Contract Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrCollCtrctId")]
    #endif
    [IsoXmlTag("SndrCollCtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SenderCollateralContractIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderCollateralContractIdentification { get; init; } 
    #else
    public System.String? SenderCollateralContractIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the collateral management contract from the triparty agent&apos;s point of view.
    /// </summary>
    [IsoId("_ihJU0PkFEeicy5Zn42b9bg")]
    [DisplayName("Receiver Collateral Contract Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrCollCtrctId")]
    #endif
    [IsoXmlTag("RcvrCollCtrctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReceiverCollateralContractIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiverCollateralContractIdentification { get; init; } 
    #else
    public System.String? ReceiverCollateralContractIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification (UTI) agreed upon by the two trade counterparties to identify the transaction/exposure or the contract.
    /// </summary>
    [IsoId("_NZbooPogEeiAfJEqh4xF_Q")]
    [DisplayName("Common Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonTxId")]
    #endif
    [IsoXmlTag("CmonTxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? CommonTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonTransactionIdentification { get; init; } 
    #else
    public System.String? CommonTransactionIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
