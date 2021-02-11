
"vim-plug install check
if !filereadable(expand('~/.vim/autoload/plug.vim'))
    if !executable("curl")
        echoerr "You have to install curl or first install vim-plug yourself!"
        execute "q!"
    endif
    echo "Installing Vim-Plug..."
    echo ""
     silent !\curl -fLo ~/.vim/autoload/plug.vim --create-dirs https://raw.githubusercontent.com/junegunn/vim-plug/master/plug.vim
    let g:not_finish_vimplug = "yes"
    autocmd VimEnter * PlugInstall
    "autocmd VimEnter * CocInstall coc-java coc-json
endif

" plugin
call plug#begin(expand('~/.vim/plugged'))

if has('nvim')
    Plug 'Shougo/defx.nvim', { 'do': ':UpdateRemotePlugins' }
else
    Plug 'Shougo/defx.nvim'
    Plug 'roxma/nvim-yarp'
    Plug 'roxma/vim-hug-neovim-rpc'
endif

"winresizer
Plug 'simeji/winresizer'

" space + ne -> sidebar
Plug 'scrooloose/nerdtree'
Plug 'jistr/vim-nerdtree-tabs'

" ga -> align
Plug 'junegunn/vim-easy-align'

" space + qr -> exec script
Plug 'thinca/vim-quickrun'

" gcc -> comment
Plug 'tpope/vim-commentary'

" option bar
Plug 'vim-airline/vim-airline'
Plug 'vim-airline/vim-airline-themes'

" auto bracket
Plug 'Raimondi/delimitMate'
Plug 'tpope/vim-surround'

" auto format
Plug 'Chiel92/vim-autoformat'

" error detect
"Plug 'scrooloose/syntastic'

" delete white space
"Plug 'bronson/vim-trailing-whitespace'
Plug 'ervandew/supertab'

" space + sh -> vimshell
Plug 'Shougo/vimshell.vim'
Plug 'dense-analysis/ale'

"indentLine
Plug 'Yggdroot/indentLine'

"LSP
Plug 'neoclide/coc.nvim', {'branch': 'release'}

call plug#end()
filetype plugin indent on

"Space -> <Leader>
let mapleader="\<Space>"

" auto-format
"au BufWrite * :Autoformat
let g:autoformat_autoindent  =  0
let g:autoformat_retab  =  0
let g:autoformat_remove_trailing_spaces  =  0

"alesetting
let g:ale_lint_on_enter = 0
let g:ale_lint_on_text_changed = 0

" quickrun
nnoremap <Leader>go :QuickRun<CR>
nnoremap <C-U>qr :QuickRun<CR>
au FileType qf nnoremap <silent><buffer>q :quit<CR>
nnoremap <expr><silent> <C-c> quickrun#is_running() ? quickrun#sweep_sessions() : "\<C-c>"
let g:quickrun_config = get(g:, 'quickrun_config', {})
let g:quickrun_config={'*': {'split': ''}}
let g:quickrun_config.cpp = {
            \   'command': 'g++',
            \   'cmdopt': '-std=c++11'
            \ }

let g:quickrun_config._ = {
            \ 'outputter/error/success': 'buffer',
            \ 'outputter/error/error': 'quickfix',
            \ 'outputter/quickfix/open_cmd': 'copen',
            \ 'runner': 'job',
            \ 'runner/vimproc/updatetime': 40,
            \ 'hook/time/enable': 1
            \ }

" vim-easy-align
xmap ga <Plug>(EasyAlign)
map ga <Plug>(EasyAlign)

" vimshell
nnoremap <Leader>sh :vertical terminal<CR>
let g:vimshell_user_prompt = 'fnamemodify(getcwd(), ":~")'
let g:vimshell_prompt =  '$ '

" vim-airline
nmap <S-Tab> <Plug>AirlineSelectPrevTab
nmap <Tab> <Plug>AirlineSelectNextTab
let g:airline#extensions#tabline#buffer_idx_mode = 1
let g:airline#extensions#virtualenv#enabled = 1

let g:airline_theme = 'murmur'
let g:airline#extensions#syntastic#enabled = 1
let g:airline#extensions#branch#enabled = 1
let g:airline#extensions#tabline#enabled = 1
let g:airline#extensions#tagbar#enabled = 1
let g:airline_skip_empty_sections = 1

if !exists('g:airline_symbols')
    let g:airline_symbols = {}
endif

"Left
let g:airline_left_sep = '>'
let g:airline_left_alt_sep = '>'

"Right
let g:airline_right_sep = '<'
let g:airline_right_alt_sep = '<'
" let g:airline_symbols.crypt = '🔒'
" let g:airline_symbols.linenr = '¶'
" let g:airline_symbols.maxlinenr = '㏑'
" let g:airline_symbols.branch = '⭠'
" let g:airline_symbols.paste = 'ρ'
" let g:airline_symbols.spell = 'Ꞩ'
" let g:airline_symbols.notexists = '∄'
" let g:airline_symbols.whitespace = 'Ξ'


" The PC is fast enough, do syntax highlight syncing from start unless 200 lines
augroup vimrc-sync-fromstart
    autocmd!
    autocmd BufEnter * :syntax sync maxlines=200
augroup END

" Remember cursor position
augroup vimrc-remember-cursor-position
    autocmd!
    autocmd BufReadPost * if line("'\"") > 1 && line("'\"") <= line("$") | exe "normal! g`\"" | endif
augroup END

" GoTo code navigation.
nmap <silent> gd <Plug>(coc-definition)
nmap <silent> gy <Plug>(coc-type-definition)
nmap <silent> gi <Plug>(coc-implementation)
nmap <silent> gr <Plug>(coc-references)


" shortcutKEY leader=Space

"NERDTree
nnoremap <silent><Leader>e :NERDTreeToggle<CR>
let g:NERDTreeChDirMode=2
let g:NERDTreeIgnore=['\.rbc$', '\~$', '\.pyc$', '\.db$', '\.sqlite$', '__pycache__']
let g:NERDTreeSortOrder=['^__\.py$', '\/$', '*', '\.swp$', '\.bak$', '\~$']
let g:NERDTreeShowBookmarks=1
let g:nerdtree_tabs_focus_on_files=1
let g:NERDTreeMapOpenInTabSilent = '<RightMouse>'
let g:NERDTreeWinSize = 30
let NERDTreeShowHidden=1
set wildignore+=*/tmp/*,*.so,*.swp,*.zip,*.pyc,*.db,*.sqlite

" autocmd BufWritePre * :FixWhitespace
augroup NERD
    au!
    " autocmd VimEnter * NERDTree
    " autocmd VimEnter * wincmd p
augroup END

" save
nnoremap <Leader>w :w<CR>
nnoremap <F12> :q!<CR>
nnoremap <Leader>eee :e<CR>
nnoremap <Leader>wq :wq<CR>
nnoremap <F3> :noh<CR>

" split
nnoremap <Leader>s :<C-u>split<CR>
nnoremap <Leader>v :<C-u>vsplit<CR>
nnoremap <Leader>o :<C-u>only<CR>
nnoremap sj <C-w>j
nnoremap sk <C-w>k
nnoremap sl <C-w>l
nnoremap sh <C-w>h

" Tabs
"nnoremap <Tab>   :tabn
"nnoremap <S-Tab>   :tabp
nnoremap <Leader>t :tabnew<CR>
nnoremap <Leader>tt :tabclose<CR>
nnoremap <Leader>ttt :bdelete<CR>

" ignore wrap
nnoremap j gj
nnoremap k gk
nnoremap <Down> gj
nnoremap <Up> gk

"indentLine:
nnoremap <silent>gg :IndentLinesToggle<CR>
let g:indentLine_enabled = 0
let g:indentLine_celor_term = 239
let g:indentLine_char = '￤' "use |, | or │

"Other
nnoremap <F5> redraw
inoremap <expr><CR>  pumvisible() ? "<C-y>" : "<CR>"
nnoremap <silent><buffer><expr> <2-LeftMouse> defx#do_action('open')

"" Sft + y => yunk to EOL
nnoremap Y ye

"" + => incremene
nnoremap + <C-a>

"" - => decrement
nnoremap - <C-x>

"" move 15 words
nnoremap <silent> ll 15<Right>
nnoremap <silent> hh 15<Left>
nnoremap <silent> jj 15<Down>
nnoremap <silent> kk 15<Up>

"move line/word
nnoremap <C-h> $
nnoremap <C-a> 0
nnoremap <C-f> W
nnoremap <C-b> B
inoremap <C-e> <C-o>$
inoremap <C-a> <C-o>0
inoremap <C-f> <C-o>W
inoremap <C-b> <C-o>B

" base
set encoding=utf-8
set fileencoding=utf-8
set fileencodings=utf-8
set autoindent
set bomb
set binary
set ttyfast
set backspace=indent,eol,start
set tabstop=4
set softtabstop=0
set shiftwidth=4
set expandtab
set splitright
set splitbelow
set hidden
set hlsearch
set incsearch
set ignorecase
set smartcase
set nobackup
set noswapfile
set fileformats=unix,dos,mac
syntax on
set ruler
set number
set gcr=a:blinkon0
set scrolloff=3
set laststatus=2
set modeline
set modelines=10
set title
set titleold="Terminal"
set titlestring=%F
set statusline=%F%m%r%h%w%=(%{&ff}/%Y)\ (line\ %l\/%L,\ col\ %c)\
set autoread
set noerrorbells visualbell t_vb=
set clipboard+=unnaeed,autoselect
set mouse=a
set whichwrap=b,s,h,l,<,>,[,]
set wildmenu
set wildmode=longest,full
set ttimeoutlen=50
"set foldmethod=indent
"set foldcolumn=3
set synmaxcol=200
set ttyfast


"LSP Color Custom
highlight Pmenu ctermfg=white ctermbg=blue
highlight PmenuSel ctermfg=white ctermbg=darkgray
highlight WildMenu cterm=underline ctermfg=white ctermbg=blue

"defx
nnoremap <silent>sf :<C-u>Defx -listed -resume
        \-columns=indent:mark:icon:icons:filename:git:size
        \-buffer-name=tab`tabpagenr()`
        \`expand('%:p:h')` -search=`expand('%:p')`<CR>
nnoremap <silent>fi :<C-u>Defx -new `expand('%:p:h')` -search=`expand('%:p')`<CR>

call defx#custom#option('_', {
      \ 'winwidth': 40,
      \ 'split': 'vertical',
      \ 'direction': 'topleft',
      \ 'show_ignored_files': 1,
      \ 'buffer_name': 'exlorer',
      \ 'toggle': 1,
      \ 'resume': 1,
      \ })

        "defx KEYBIND
        autocmd FileType defx call s:defx_my_settings()
        function! s:defx_my_settings() abort
            " Define mappings
            nnoremap <silent><buffer><expr> <CR>
                        \ defx#do_action('open')
            nnoremap <silent><buffer><expr> c
                        \ defx#do_action('copy')
            nnoremap <silent><buffer><expr> m
                        \ defx#do_action('move')
            nnoremap <silent><buffer><expr> p
                        \ defx#do_action('paste')
            nnoremap <silent><buffer><expr> l
                        \ defx#do_action('open')
            nnoremap <silent><buffer><expr> E
                        \ defx#do_action('open', 'vsplit')
            nnoremap <silent><buffer><expr> P
                        \ defx#do_action('preview')
            nnoremap <silent><buffer><expr> o
                        \ defx#do_action('open_tree', 'toggle')
            nnoremap <silent><buffer><expr> K
                        \ defx#do_action('new_directory')
            nnoremap <silent><buffer><expr> N
                        \ defx#do_action('new_file')
            nnoremap <silent><buffer><expr> M
                        \ defx#do_action('new_multiple_files')
            nnoremap <silent><buffer><expr> C
                        \ defx#do_action('toggle_columns',
                        \                'mark:indent:icon:filename:type:size:time')
            nnoremap <silent><buffer><expr> S
                        \ defx#do_action('toggle_sort', 'time')
            nnoremap <silent><buffer><expr> d
                        \ defx#do_action('remove')
            nnoremap <silent><buffer><expr> r
                        \ defx#do_action('rename')
            nnoremap <silent><buffer><expr> !
                        \ defx#do_action('execute_command')
            nnoremap <silent><buffer><expr> x
                        \ defx#do_action('execute_system')
            nnoremap <silent><buffer><expr> yy
                        \ defx#do_action('yank_path')
            nnoremap <silent><buffer><expr> .
                        \ defx#do_action('toggle_ignored_files')
            nnoremap <silent><buffer><expr> ;
                        \ defx#do_action('repeat')
            nnoremap <silent><buffer><expr> h
                        \ defx#do_action('cd', ['..'])
            nnoremap <silent><buffer><expr> ~
                        \ defx#do_action('cd')
            nnoremap <silent><buffer><expr> q
                        \ defx#do_action('quit')
            nnoremap <silent><buffer><expr> <Space>
                        \ defx#do_action('toggle_select') . 'j'
            nnoremap <silent><buffer><expr> *
                        \ defx#do_action('toggle_select_all')
            nnoremap <silent><buffer><expr> j
                        \ line('.') == line('$') ? 'gg' : 'j'
            nnoremap <silent><buffer><expr> k
                        \ line('.') == 1 ? 'G' : 'k'
            nnoremap <silent><buffer><expr> <C-l>
                        \ defx#do_action('redraw')
            nnoremap <silent><buffer><expr> <C-g>
                        \ defx#do_action('print')
            nnoremap <silent><buffer><expr> cd
                        \ defx#do_action('change_vim_cwd')
        endfunction
