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
namespace BeneficialStrategies.Iso20022.Choices.ExerciseDate1Choice
{
    /// <summary>
    /// Specifies the earliest unadjusted date during the exercise period on which an option can be exercised.
    /// ||Usage|: For European style options, the first possible exercise date is the same as the ExpirationDate.|
    /// For American style options, the first possible exercise date is the same as the ExecutionTimeStamp.|
    /// For Knock-in options, the first exercise date is reported when available.
    /// </summary>
    [IsoId("_Y7c_sgbBEeqrW7Meu5r3kQ")]
    [DisplayName("First Exercise Date")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FirstExerciseDate : ExerciseDate1Choice_
    #else
    public partial class FirstExerciseDate : ExerciseDate1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FirstExerciseDate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FirstExerciseDate( System.DateOnly reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// A particular point in the progression of time in a calendar year expressed in the YYYY-MM-DD format. This representation is defined in &quot;XML Schema Part 2: Datatypes Second Edition - W3C Recommendation 28 October 2004&quot; which is aligned with ISO 8601.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrstExrcDt")]
        #endif
        [IsoXmlTag("FrstExrcDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly Value { get; init; } 
        #else
        public System.DateOnly Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
