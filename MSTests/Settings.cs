// настройка параллелизма на уровне сборки

using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 5, Scope = ExecutionScope.)]
//[assembly: Parallelize(Workers = 3, Scope = ExecutionScope.ClassLevel)]

namespace MSTests
{
}