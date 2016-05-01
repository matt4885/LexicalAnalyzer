# LexicalAnalyzer

This is an implementation of a lexical analyzer for the C- language presented in an introctory undergraduate language translation 
(Compilers) course. Implemented in C#, the objective of the project is to take an OOP approach towards design, implying modularity,
inheritance, and interfaces. The eventual goal is to have the four major componenents of the compiler working in cooperation, that is,
the lexical analyzer, the parser, the semantic analyzer and immediate code generator. 

So with that being said, let's see what works and what doesn't (what needs to be implemented):

WORKING:
keywords,
ids,
numbers,
delimiting symbols

NOT WORKING:
symbol table,
rationalizing between comments and non-comment lines
