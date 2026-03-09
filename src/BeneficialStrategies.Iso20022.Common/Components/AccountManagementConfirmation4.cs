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
/// Information about the type of request or instruction.
/// </summary>
[IsoId("_ax-xUUzLEeafiMTDrtSnyw")]
[DisplayName("Account Management Confirmation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountManagementConfirmation4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountManagementConfirmation4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountManagementConfirmation4( ConfirmationType1Choice_ reqConfirmationType )
    {
        ConfirmationType = reqConfirmationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the confirmation type.
    /// </summary>
    [IsoId("_bMBB8UzLEeafiMTDrtSnyw")]
    [DisplayName("Confirmation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfTp")]
    #endif
    [IsoXmlTag("ConfTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConfirmationType1Choice_ ConfirmationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConfirmationType1Choice_ ConfirmationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConfirmationType1Choice_ ConfirmationType { get; init; } 
    #else
    public ConfirmationType1Choice_ ConfirmationType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of the account opening or modification instruction at application level.
    /// </summary>
    [IsoId("_bMBB80zLEeafiMTDrtSnyw")]
    [DisplayName("Account Application Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctApplId")]
    #endif
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountApplicationIdentification { get; init; } 
    #else
    public System.String? AccountApplicationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of a transaction, for example, a transfer, as assigned by the investor or account owner.
    /// </summary>
    [IsoId("_bMBB9UzLEeafiMTDrtSnyw")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientReference { get; init; } 
    #else
    public System.String? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    [IsoId("_bMBB90zLEeafiMTDrtSnyw")]
    [DisplayName("Counterparty Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRef")]
    #endif
    [IsoXmlTag("CtrPtyRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference6? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference6? CounterpartyReference { get; init; } 
    #else
    public AdditionalReference6? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [IsoId("_bMBB-UzLEeafiMTDrtSnyw")]
    [DisplayName("Existing Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExstgAcctId")]
    #endif
    [IsoXmlTag("ExstgAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Account23? ExistingAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Account23? ExistingAccountIdentification { get; init; } 
    #else
    public Account23? ExistingAccountIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
