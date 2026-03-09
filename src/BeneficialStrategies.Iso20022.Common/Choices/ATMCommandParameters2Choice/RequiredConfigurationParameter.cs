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
namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice
{
    /// <summary>
    /// Parameters to be used by the configuration update command.
    /// </summary>
    [IsoId("_qAYftYtHEeSxlKlAGYErFg")]
    [DisplayName("Required Configuration Parameter")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RequiredConfigurationParameter : ATMCommandParameters2Choice_
    #else
    public partial class RequiredConfigurationParameter : ATMCommandParameters2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RequiredConfigurationParameter instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RequiredConfigurationParameter( DataSetCategory7Code reqType,System.String reqVersion )
        {
            Type = reqType;
            Version = reqVersion;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of the ATM configuration.
        /// </summary>
        [IsoId("_MrLhwIn-EeShMpas3885ww")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DataSetCategory7Code Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DataSetCategory7Code Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DataSetCategory7Code Type { get; init; } 
        #else
        public DataSetCategory7Code Type { get; set; } 
        #endif
        
        /// <summary>
        /// Active version of the configuration.
        /// </summary>
        [IsoId("_TcxKUIn-EeShMpas3885ww")]
        [DisplayName("Version")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Vrsn")]
        #endif
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Version { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Version { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Version { get; init; } 
        #else
        public System.String Version { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
