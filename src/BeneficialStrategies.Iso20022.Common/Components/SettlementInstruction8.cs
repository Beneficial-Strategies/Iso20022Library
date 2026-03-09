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
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_VOSH0Xh1EeidzqjNEfehPg")]
[DisplayName("Settlement Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInstruction8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInstruction8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInstruction8( SettlementMethod2Code reqSettlementMethod )
    {
        SettlementMethod = reqSettlementMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_VdkhB3h1EeidzqjNEfehPg")]
    [DisplayName("Settlement Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmMtd")]
    #endif
    [IsoXmlTag("SttlmMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementMethod2Code SettlementMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementMethod2Code SettlementMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementMethod2Code SettlementMethod { get; init; } 
    #else
    public SettlementMethod2Code SettlementMethod { get; set; } 
    #endif
    
    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_VdkhCXh1EeidzqjNEfehPg")]
    [DisplayName("Settlement Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAcct")]
    #endif
    [IsoXmlTag("SttlmAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount38? SettlementAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount38? SettlementAccount { get; init; } 
    #else
    public CashAccount38? SettlementAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_VdkhC3h1EeidzqjNEfehPg")]
    [DisplayName("Clearing System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSys")]
    #endif
    [IsoXmlTag("ClrSys")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    #else
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
