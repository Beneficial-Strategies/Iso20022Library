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
namespace BeneficialStrategies.Iso20022.Choices.IdentificationType1Choice
{
    /// <summary>
    /// Specifies a type of individual identification.
    /// </summary>
    [IsoId("_QAoQJ9p-Ed-ak6NoX_4Aeg_-1246497918")]
    [DisplayName("Identification Type")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IdentificationType : IdentificationType1Choice_
    #else
    public partial class IdentificationType : IdentificationType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IdentificationType instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IdentificationType( PersonIdentificationType2Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IdTp")]
        #endif
        [IsoXmlTag("IdTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PersonIdentificationType2Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PersonIdentificationType2Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PersonIdentificationType2Code Value { get; init; } 
        #else
        public PersonIdentificationType2Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
