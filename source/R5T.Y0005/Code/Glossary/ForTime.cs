using System;

using R5T.T0156;


namespace R5T.Y0005
{
    public static partial class Glossary
    {
        [DocumentationMarker]
        public static class ForTime
        {
            /// <summary>
            /// <inheritdoc cref="Microseconds" path="/definition"/>
            /// </summary>
            /// <definition>Microseconds (μs, millionths of a second)</definition>
            /// <name><i>microseconds</i></name>
            /// <display>microseconds (μs, millionths of a second)</display>
            /// <unit-description>μs, millionths of a second</unit-description>
            /// <unit-symbol>μs</unit-symbol>
            /// <unit-name>μs</unit-name>
            public static readonly object Microseconds;

            /// <summary>
            /// <inheritdoc cref="Milliseconds" path="/definition"/>
            /// </summary>
            /// <definition>Milliseconds (ms, thousandths of a second)</definition>
            /// <name><i>milliseconds</i></name>
            /// <display>milliseconds (ms, thousandths of a second)</display>
            /// <unit-description>ms, thousandths of a second</unit-description>
            /// <unit-symbol>ms</unit-symbol>
            /// <unit-name>ms</unit-name>
            public static readonly object Milliseconds;

            /// <summary>
            /// <inheritdoc cref="Nanoseconds" path="/definition"/>
            /// </summary>
            /// <definition>Nanoseconds (ns, billionths of a second)</definition>
            /// <name><i>nanoseconds</i></name>
            /// <display>nanoseconds (ns, billionths of a second)</display>
            /// <unit-description>ns, billionths of a second</unit-description>
            /// <unit-symbol>ns</unit-symbol>
            /// <unit-name>ns</unit-name>
            public static readonly object Nanoseconds;
        }
    }
}
