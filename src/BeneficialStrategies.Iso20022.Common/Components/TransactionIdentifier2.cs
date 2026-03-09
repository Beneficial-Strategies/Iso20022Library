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
/// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
/// </summary>
[IsoId("_18UEUXsvEeSTS7uHCe8FPQ")]
[DisplayName("Transaction Identifier")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionIdentifier2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionIdentifier2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionIdentifier2( System.DateOnly reqReconciliationDate )
    {
        ReconciliationDate = reqReconciliationDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the reconciliation.
    /// It correspond to the ISO 8583 field number 28 for the versions 1993 and 2003.
    /// </summary>
    [IsoId("_Ai_vIHswEeSTS7uHCe8FPQ")]
    [DisplayName("Reconciliation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnDt")]
    #endif
    [IsoXmlTag("RcncltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ReconciliationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ReconciliationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ReconciliationDate { get; init; } 
    #else
    public System.DateOnly ReconciliationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation.
    /// It correspond to the ISO 8583 field number 29 for the versions 1993 and 2003.
    /// </summary>
    [IsoId("_Hn8YkHswEeSTS7uHCe8FPQ")]
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
    
    
    #nullable disable
    
}
