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
namespace BeneficialStrategies.Iso20022.Choices.StatementBasisCodeAndDSSCodeChoice
{
    /// <summary>
    /// Statement basis expressed as a code.
    /// </summary>
    [IsoId("_Q7Cp8dp-Ed-ak6NoX_4Aeg_-1663061250")]
    [DisplayName("Statement Basis As Code")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StatementBasisAsCode : StatementBasisCodeAndDSSCodeChoice_
    #else
    public partial class StatementBasisAsCode : StatementBasisCodeAndDSSCodeChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a StatementBasisAsCode instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public StatementBasisAsCode( StatementBasis1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of balances on which the statement is prepared.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StmtBsisAsCd")]
        #endif
        [IsoXmlTag("StmtBsisAsCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required StatementBasis1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required StatementBasis1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public StatementBasis1Code Value { get; init; } 
        #else
        public StatementBasis1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
