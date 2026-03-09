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
/// Transaction for which the exception is sent.
/// </summary>
[IsoId("_KIj5ca5FEeWCgYcWSNgX5g")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction27
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_KTvOs65FEeWCgYcWSNgX5g")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period.
    /// </summary>
    [IsoId("_KTvOta5FEeWCgYcWSNgX5g")]
    [DisplayName("Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnId")]
    #endif
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReconciliationIdentification { get; init; } 
    #else
    public System.String? ReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Exception occurring outside the service.
    /// </summary>
    [IsoId("_fA9EoK5FEeWCgYcWSNgX5g")]
    [DisplayName("Exception")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xcptn")]
    #endif
    [IsoXmlTag("Xcptn")]
    public SimpleValueList<FailureReason8Code> Exception { get; init; } = new SimpleValueList<FailureReason8Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _fA9EoK5FEeWCgYcWSNgX5g
    
    /// <summary>
    /// Explanation of the exception.
    /// </summary>
    [IsoId("_57VncK5FEeWCgYcWSNgX5g")]
    [DisplayName("Exception Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcptnDtl")]
    #endif
    [IsoXmlTag("XcptnDtl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ExceptionDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExceptionDetail { get; init; } 
    #else
    public System.String? ExceptionDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of the captured card or epurse if available.
    /// </summary>
    [IsoId("_CX6yMK5GEeWCgYcWSNgX5g")]
    [DisplayName("Electronic Purse Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctrncPrsBal")]
    #endif
    [IsoXmlTag("ElctrncPrsBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? ElectronicPurseBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? ElectronicPurseBalance { get; init; } 
    #else
    public CurrencyAndAmount? ElectronicPurseBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
