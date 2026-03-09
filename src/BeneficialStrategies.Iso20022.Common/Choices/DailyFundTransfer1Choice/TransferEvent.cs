// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.DailyFundTransfer1Choice
{
    /// <summary>
    /// Information about code and number of transfer.
    /// </summary>
    [IsoId("_WJO-ECc7Eea7avjfd7yDAA")]
    [DisplayName("Transfer Event")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record TransferEvent : DailyFundTransfer1Choice_
    #else
    public partial class TransferEvent : DailyFundTransfer1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a TransferEvent instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public TransferEvent( System.String reqEventCode )
        {
            EventCode = reqEventCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Code of fund transfer event.
        /// </summary>
        [IsoId("_Mmm70Cc8Eea7avjfd7yDAA")]
        [DisplayName("Event Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtCd")]
        #endif
        [IsoXmlTag("EvtCd")]
        [IsoSimpleType(IsoSimpleType.Max4Text)]
        [StringLength(maximumLength: 4 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax4Text EventCode { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String EventCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String EventCode { get; init; } 
        #else
        public System.String EventCode { get; set; } 
        #endif
        
        /// <summary>
        /// Event number related to the event code.
        /// </summary>
        [IsoId("_ReAIkCc8Eea7avjfd7yDAA")]
        [DisplayName("Event Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtNb")]
        #endif
        [IsoXmlTag("EvtNb")]
        [IsoSimpleType(IsoSimpleType.Max3NumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax3NumericText? EventNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EventNumber { get; init; } 
        #else
        public System.String? EventNumber { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
