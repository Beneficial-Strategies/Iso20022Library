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
/// Addendum message is used in conjunction with an authorisation or financial message to provide supplemental data above that required to complete an authorisation initiation or financial initiation. 
/// </summary>
[IsoId("_RtF34YdIEeuBS50MFjViNw")]
[DisplayName("Addendum Initiation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AddendumInitiation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AddendumInitiation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AddendumInitiation2( Environment30 reqEnvironment,Transaction148 reqTransaction,AddendumData3 reqAddendumData )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
        AddendumData = reqAddendumData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains or describes the information pertaining to the actors interacting with the transaction.
    /// </summary>
    [IsoId("_RyTIAYdIEeuBS50MFjViNw")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Environment30 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Environment30 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Environment30 Environment { get; init; } 
    #else
    public Environment30 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_RyTIA4dIEeuBS50MFjViNw")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Context17? Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Context17? Context { get; init; } 
    #else
    public Context17? Context { get; set; } 
    #endif
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_RyTIBYdIEeuBS50MFjViNw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transaction148 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transaction148 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transaction148 Transaction { get; init; } 
    #else
    public Transaction148 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages. 
    /// </summary>
    [IsoId("_RyTIB4dIEeuBS50MFjViNw")]
    [DisplayName("Addendum Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdddmData")]
    #endif
    [IsoXmlTag("AdddmData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AddendumData3 AddendumData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AddendumData3 AddendumData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddendumData3 AddendumData { get; init; } 
    #else
    public AddendumData3 AddendumData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_RyTICYdIEeuBS50MFjViNw")]
    [DisplayName("Protected Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdData")]
    #endif
    [IsoXmlTag("PrtctdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProtectedData1? ProtectedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProtectedData1? ProtectedData { get; init; } 
    #else
    public ProtectedData1? ProtectedData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_RyTIC4dIEeuBS50MFjViNw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
