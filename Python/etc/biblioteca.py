class Livro:
    def __init__(self, titulo, autor, ano):
        self.titulo = titulo
        self.autor = autor
        self.ano = ano
        self.disponivel = True

    def emprestar(self):
        if self.disponivel:
            self.disponivel = False
            return True
        return False

    def devolver(self):
        self.disponivel = True

    def __str__(self):
        status = "disponível" if self.disponivel else "emprestado"
        return f"{self.titulo} por {self.autor} ({self.ano}) - {status}"


class Biblioteca:
    def __init__(self):
        self.livros = []

    def adicionar_livro(self, livro):
        self.livros.append(livro)

    def emprestar_livro(self, titulo):
        for livro in self.livros:
            if livro.titulo == titulo and livro.emprestar():
                return f"Livro '{titulo}' emprestado com sucesso."
        return f"Livro '{titulo}' não está disponível para empréstimo."

    def devolver_livro(self, titulo):
        for livro in self.livros:
            if livro.titulo == titulo:
                livro.devolver()
                return f"Livro '{titulo}' devolvido com sucesso."
        return f"Livro '{titulo}' não encontrado na biblioteca."

    def listar_livros(self):
        return [str(livro) for livro in self.livros]


# Teste do sistema
biblioteca = Biblioteca()

# Adicionar livros
biblioteca.adicionar_livro(Livro("Dom Quixote", "Miguel de Cervantes", 1605))
biblioteca.adicionar_livro(Livro("1984", "George Orwell", 1949))
biblioteca.adicionar_livro(Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943))

# Listar livros
print("Livros na biblioteca:")
for livro in biblioteca.listar_livros():
    print(livro)

# Emprestar um livro
print("\n", biblioteca.emprestar_livro("1984"))

# Tentar emprestar o mesmo livro novamente
print(biblioteca.emprestar_livro("1984"))

# Devolver o livro
print(biblioteca.devolver_livro("1984"))

# Listar livros novamente
print("\nLivros na biblioteca após operações:")
for livro in biblioteca.listar_livros():
    print(livro)