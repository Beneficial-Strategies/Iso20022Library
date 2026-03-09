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
/// Deposited media put in the safe.
/// </summary>
[IsoId("_jeG9UK4BEeWL1uap3dNhCQ")]
[DisplayName("ATM Deposited Media")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMDepositedMedia1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMDepositedMedia1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMDepositedMedia1( ATMMediaType2Code reqMediaType )
    {
        MediaType = reqMediaType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Link to the account for multi-account deposit.
    /// </summary>
    [IsoId("_tkpvgK4BEeWL1uap3dNhCQ")]
    [DisplayName("Account Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctSeqNb")]
    #endif
    [IsoXmlTag("AcctSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? AccountSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? AccountSequenceNumber { get; init; } 
    #else
    public System.UInt64? AccountSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Type of deposited media.
    /// </summary>
    [IsoId("_cTRR0K4CEeWL1uap3dNhCQ")]
    [DisplayName("Media Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdiaTp")]
    #endif
    [IsoXmlTag("MdiaTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMMediaType2Code MediaType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMMediaType2Code MediaType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaType2Code MediaType { get; init; } 
    #else
    public ATMMediaType2Code MediaType { get; set; } 
    #endif
    
    /// <summary>
    /// Category of deposited media items.
    /// </summary>
    [IsoId("_1FGMsK4CEeWL1uap3dNhCQ")]
    [DisplayName("Media Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdiaCtgy")]
    #endif
    [IsoXmlTag("MdiaCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMMediaType3Code? MediaCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMMediaType3Code? MediaCategory { get; init; } 
    #else
    public ATMMediaType3Code? MediaCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Media item that are deposited.
    /// </summary>
    [IsoId("_l3I_UK4DEeWL1uap3dNhCQ")]
    [DisplayName("Media Items")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MdiaItms")]
    #endif
    [IsoXmlTag("MdiaItms")]
    public ValueList<ATMDepositedMedia2> MediaItems { get; init; } = new ValueList<ATMDepositedMedia2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _l3I_UK4DEeWL1uap3dNhCQ
    
    
    #nullable disable
    
}
