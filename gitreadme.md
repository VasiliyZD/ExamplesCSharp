echo "# git" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/VasiliyZD/git.git
--allow-unrelated-histories
git push -u origin main