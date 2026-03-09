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
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus4Choice
{
    /// <summary>
    /// Specifies the status of the investigation, in a coded form.
    /// </summary>
    [IsoId("_nbwAk4mxEeeKR__nUfxjwA")]
    [DisplayName("Confirmation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Confirmation : InvestigationStatus4Choice_
    #else
    public partial class Confirmation : InvestigationStatus4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Confirmation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Confirmation( ExternalInvestigationExecutionConfirmation1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the result of an investigation, as published in an external investigation execution confirmation code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Conf")]
        #endif
        [IsoXmlTag("Conf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExternalInvestigationExecutionConfirmation1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExternalInvestigationExecutionConfirmation1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalInvestigationExecutionConfirmation1Code Value { get; init; } 
        #else
        public ExternalInvestigationExecutionConfirmation1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
