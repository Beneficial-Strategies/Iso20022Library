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
/// Data to request to enable a service.
/// </summary>
[IsoId("_LIrhUQ0tEeqUVL7sB4m7NA")]
[DisplayName("Enable Service Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnableServiceRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EnableServiceRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EnableServiceRequest2( TransactionAction1Code reqTransactionAction )
    {
        TransactionAction = reqTransactionAction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Action to realise on a transaction.
    /// </summary>
    [IsoId("_LUWl0Q0tEeqUVL7sB4m7NA")]
    [DisplayName("Transaction Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxActn")]
    #endif
    [IsoXmlTag("TxActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionAction1Code TransactionAction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionAction1Code TransactionAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAction1Code TransactionAction { get; init; } 
    #else
    public TransactionAction1Code TransactionAction { get; set; } 
    #endif
    
    /// <summary>
    /// Services enabled before the start-up of a transaction.
    /// </summary>
    [IsoId("_LUWl0w0tEeqUVL7sB4m7NA")]
    [DisplayName("Services Enabled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcsNbld")]
    #endif
    [IsoXmlTag("SvcsNbld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RetailerService2Code? ServicesEnabled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerService2Code? ServicesEnabled { get; init; } 
    #else
    public RetailerService2Code? ServicesEnabled { get; set; } 
    #endif
    
    /// <summary>
    /// Prompt or welcome message.
    /// </summary>
    [IsoId("_LUWl1Q0tEeqUVL7sB4m7NA")]
    [DisplayName("Display Output")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DispOutpt")]
    #endif
    [IsoXmlTag("DispOutpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage7? DisplayOutput { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage7? DisplayOutput { get; init; } 
    #else
    public ActionMessage7? DisplayOutput { get; set; } 
    #endif
    
    
    #nullable disable
    
}
