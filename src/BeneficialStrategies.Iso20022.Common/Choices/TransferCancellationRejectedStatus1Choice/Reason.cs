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
namespace BeneficialStrategies.Iso20022.Choices.TransferCancellationRejectedStatus1Choice
{
    /// <summary>
    /// Reason of the rejected status.
    /// </summary>
    [IsoId("_U0fAs9p-Ed-ak6NoX_4Aeg_1742304027")]
    [DisplayName("Reason")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reason : TransferCancellationRejectedStatus1Choice_
    #else
    public partial class Reason : TransferCancellationRejectedStatus1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reason instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reason( CancellationRejectedReason1Code reqStructured )
        {
            Structured = reqStructured;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reason for a rejected status in structured form.
        /// </summary>
        [IsoId("_U0fAttp-Ed-ak6NoX_4Aeg_1814337906")]
        [DisplayName("Structured")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Strd")]
        #endif
        [IsoXmlTag("Strd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CancellationRejectedReason1Code Structured { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CancellationRejectedReason1Code Structured { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CancellationRejectedReason1Code Structured { get; init; } 
        #else
        public CancellationRejectedReason1Code Structured { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the reason for the rejected status in textual form.
        /// </summary>
        [IsoId("_U0fAt9p-Ed-ak6NoX_4Aeg_1814337864")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalInformation { get; init; } 
        #else
        public System.String? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
