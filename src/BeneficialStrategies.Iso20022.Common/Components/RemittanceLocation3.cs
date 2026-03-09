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
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_duvyIaMDEeKl_NvHIICqIw")]
[DisplayName("Remittance Location")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceLocation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RemittanceLocation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RemittanceLocation3( TransactionReferences4 reqReferences )
    {
        References = reqReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [IsoId("_d5UqdaMDEeKl_NvHIICqIw")]
    [DisplayName("Remittance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtId")]
    #endif
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemittanceIdentification { get; init; } 
    #else
    public System.String? RemittanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    [IsoId("_mM_w0KMDEeKl_NvHIICqIw")]
    [DisplayName("Remittance Location Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtLctnDtls")]
    #endif
    [IsoXmlTag("RmtLctnDtls")]
    public ValueList<RemittanceLocationDetails1> RemittanceLocationDetails { get; init; } = new ValueList<RemittanceLocationDetails1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _mM_w0KMDEeKl_NvHIICqIw
    
    /// <summary>
    /// Identifies the underlying transaction.
    /// </summary>
    [IsoId("_kAnF1ai2EeK6T65WbewxKQ")]
    [DisplayName("References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Refs")]
    #endif
    [IsoXmlTag("Refs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionReferences4 References { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionReferences4 References { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReferences4 References { get; init; } 
    #else
    public TransactionReferences4 References { get; set; } 
    #endif
    
    
    #nullable disable
    
}
